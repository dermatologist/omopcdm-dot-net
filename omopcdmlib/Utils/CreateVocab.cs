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



        public void Create(int count = 147483648){

            // DRUG_STRENGTH.csv
            var dsr = new ReadCdmFile<DrugStrength>();
            var ds = dsr.Read(VocabPath + "DRUG_STRENGTH.csv", count);
            var dsw = new WriteCdmDb<DrugStrength>();
            dsw.Write(ds, CdmContext);

            // CONCEPT.csv
            var cor = new ReadCdmFile<Concept>();
            var concepts = cor.Read(VocabPath + "CONCEPT.csv", count);
            var cow = new WriteCdmDb<Concept>();
            cow.Write(concepts, CdmContext);

             // CONCEPT_RELATIONSHIP.csv
            var crr = new ReadCdmFile<ConceptRelationship>();
            var cr = crr.Read(VocabPath + "CONCEPT_RELATIONSHIP.csv", count);
            var crw = new WriteCdmDb<ConceptRelationship>();
            crw.Write(cr, CdmContext);

            // CONCEPT_ANCESTOR.csv
            var car = new ReadCdmFile<ConceptAncestor>();
            var ca = car.Read(VocabPath + "CONCEPT_ANCESTOR.csv", count);
            var caw = new WriteCdmDb<ConceptAncestor>();
            caw.Write(ca, CdmContext);

            // CONCEPT_SYNONYM.csv
            var csr = new ReadCdmFile<ConceptSynonym>();
            var cs = csr.Read(VocabPath + "CONCEPT_SYNONYM.csv", count);
            var csw = new WriteCdmDb<ConceptSynonym>();
            csw.Write(cs, CdmContext);

            // VOCABULARY.csv
            var vor = new ReadCdmFile<Vocabulary>();
            var vo = vor.Read(VocabPath + "VOCABULARY.csv", count);
            var vow = new WriteCdmDb<Vocabulary>();
            vow.Write(vo, CdmContext);

            // RELATIONSHIP.csv
            var rer = new ReadCdmFile<Relationship>();
            var re = rer.Read(VocabPath + "RELATIONSHIP.csv", count);
            var rew = new WriteCdmDb<Relationship>();
            rew.Write(re, CdmContext);

            // CONCEPT_CLASS.csv
            var ccr = new ReadCdmFile<ConceptClass>();
            var cc = ccr.Read(VocabPath + "CONCEPT_CLASS.csv", count);
            var ccw = new WriteCdmDb<ConceptClass>();
            ccw.Write(cc, CdmContext);

            // DOMAIN.csv
            var door = new ReadCdmFile<Domain>();
            var doo = door.Read(VocabPath + "DOMAIN.csv", count);
            var doow = new WriteCdmDb<Domain>();
            doow.Write(doo, CdmContext);
        }
        
    }
}


