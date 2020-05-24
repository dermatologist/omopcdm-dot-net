using omopcdmlib.Models;

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

            // DRUG_STRENGTH.csv
            var dsr = new ReadCdmFile<DrugStrength>();
            var ds = dsr.Read(VocabPath + "DRUG_STRENGTH.csv");
            var dsw = new WriteCdmDb<DrugStrength>();
            dsw.Write(ds, CdmContext);

            // CONCEPT.csv
            var cr = new ReadCdmFile<Concept>();
            var concepts = cr.Read(VocabPath + "CONCEPT.csv");
            var cw = new WriteCdmDb<Concept>();
            cw.Write(concepts, CdmContext);
        }
        
    }
}


