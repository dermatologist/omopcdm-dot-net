using System;
using System.Collections.Generic;
using omopcdmlib.Models;

namespace omopcdmlib.Utils
{
    public partial class CreateVocab
    {

        public string VocabPath { get; set; }

        public OmopCdmContext dbContext {get; set; }


        private Concept[] concepts;
         
        public void create(){

            TextReader reader = new StreamReader(VocabPath + "CONCEPT.csv");
            var csvReader = new CsvReader(reader);
            var concepts = csvReader.GetRecords<Concept>();
        }
    }
}
