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

            // // var reader = new StreamReader(VocabPath + "CONCEPT.csv");
            // // var csvReader = new CsvReader(reader);
            // // var concepts = csvReader.GetRecords<Concept>();
            //
            // var config = new CsvHelper.Configuration.CsvConfiguration(CultureInfo.InvariantCulture)
            // {
            //     HasHeaderRecord = true,
            //     HeaderValidated = null,
            //     MissingFieldFound = null,
            //     IgnoreBlankLines = false,
            //     Delimiter = "\t",
            //     PrepareHeaderForMatch = (string header, int index) => TitleCaseConvert(header)
            // };
            // using var reader = new StreamReader(VocabPath + "CONCEPT.csv");
            // using var csv = new CsvReader(reader, config);
            //
            // var concepts = csv.GetRecords<Concept>().ToList();
            // //List<Concept> concepts = records.ToList();

            var omopreader = new OmopReadCsv<Concept>();
            var concepts = omopreader.Read(VocabPath + "CONCEPT.csv");
            var omopwriter = new OmopWriteDb<Concept>();
            omopwriter.omopwrite(concepts, CdmContext);
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
            //     CdmContext.BulkInsert(concepts);
            //     using (var transaction = CdmContext.Database.BeginTransaction())
            //     {
            //         CdmContext.BulkInsert(concepts);
            //         transaction.Commit();
            //     }
            //     
            // }
        }
        
    }

    public class OmopReadCsv<T>
    {
        public List<T> Read(string filename)
        {
            var config = new CsvHelper.Configuration.CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true,
                HeaderValidated = null,
                MissingFieldFound = null,
                IgnoreBlankLines = false,
                Delimiter = "\t",
                PrepareHeaderForMatch = (string header, int index) => TitleCaseConvert(header)
            };
            using var reader = new StreamReader(filename);
            using var csv = new CsvReader(reader, config);
            
            var records = csv.GetRecords<T>().ToList();
            return records;
        }
        private static string TitleCaseConvert(string title)
        { 
            return new CultureInfo("en").TextInfo.ToTitleCase(title.ToLower().Replace("_", " ")).Replace(" ", "");
        }


    }

    public class OmopWriteDb<T>
    {
        public void omopwrite(List<T> towrite, OmopCdmContext CdmContext)
        {
            if (CdmContext.Database.IsSqlite())
            {
                using (var connection = (SqliteConnection)CdmContext.Database.GetDbConnection())
                {
                    connection.Open();
                    using (var transaction = connection.BeginTransaction())
                    {
                        var bulkConfig = new BulkConfig() { SqliteConnection = connection, SqliteTransaction = transaction };
                        CdmContext.BulkInsert(towrite, bulkConfig);
                        transaction.Commit();
                    }
                }
            }
            else
            {
                CdmContext.BulkInsert(towrite);
                using (var transaction = CdmContext.Database.BeginTransaction())
                {
                    CdmContext.BulkInsert(towrite);
                    transaction.Commit();
                }
                
            }
        }
    }

}


