using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using omopcdmlib.Models;
using CsvHelper;
using EFCore.BulkExtensions;
using System.Linq;

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

            // var reader = new StreamReader(VocabPath + "CONCEPT.csv");
            // var csvReader = new CsvReader(reader);
            // var concepts = csvReader.GetRecords<Concept>();

            var config = new CsvHelper.Configuration.CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true,
                HeaderValidated = null
                // MissingFieldFound = null,
                // IgnoreBlankLines = false
            };
            using var reader = new StreamReader(VocabPath + "CONCEPT.csv");
            using var csv = new CsvReader(reader, config);
            var records = csv.GetRecords<Concept>();
            List<Concept> concepts = records.ToList();
            CdmContext.BulkInsert(concepts);
        }
    }
}
