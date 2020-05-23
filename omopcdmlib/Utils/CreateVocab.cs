using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using omopcdmlib.Models;
using CsvHelper;

namespace omopcdmlib.Utils
{
    public partial class CreateVocab
    {

        public string VocabPath { get; set; }

        public OmopCdmContext dbContext {get; set; }


        private Concept[] concepts;
         
        public void create(){

            // var reader = new StreamReader(VocabPath + "CONCEPT.csv");
            // var csvReader = new CsvReader(reader);
            // var concepts = csvReader.GetRecords<Concept>();

            using (var reader = new StreamReader(VocabPath + "CONCEPT.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {    
                var records = csv.GetRecords<Concept>();
            }
        }
    }
}
