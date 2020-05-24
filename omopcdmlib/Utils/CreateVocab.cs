using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using omopcdmlib.Models;
using CsvHelper;
using EFCore.BulkExtensions;
using System.Linq;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace omopcdmlib.Utils
{
    public partial class CreateVocab
    {
        private string VocabPath { get; set; }

        public OmopCdmContext CdmContext {get; set; }

        public CreateVocab(string path, OmopCdmContext context)
        {
            VocabPath = path;
            CdmContext = context;
        }



        public void Create(){

            var omopreader = new ReadCdmFile<Concept>();
            var concepts = omopreader.Read(VocabPath + "CONCEPT.csv");
            var omopwriter = new WriteCdmDb<Concept>();
            omopwriter.Write(concepts, CdmContext);
            // if (CdmContext.Database.IsSqlite())
            // {
            //     using (var connection = (SqliteConnection)CdmContext.Database.GetDbConnection())
            //     {
            //         connection.Open();
            //         using (var transaction = connection.BeginTransaction())
            //         {
            //             var bulkConfig = new BulkConfig() { SqliteConnection = connection, SqliteTransaction = transaction };
            //             CdmContext.BulkInsert(concepts, bulkConfig);
            //             transaction.Commit();
            //         }
            //     }
            // }
            // else
            // {
            //     using (var transaction = CdmContext.Database.BeginTransaction())
            //     {
            //         CdmContext.BulkInsert(concepts);
            //         transaction.Commit();
            //     }
            //     
            // }
        }
        
    }
}


