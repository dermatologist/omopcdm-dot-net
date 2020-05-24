# omopcdm-dot-net

## Description

The OHSDI OMOP Common Data Model allows for the systematic analysis of healthcare observational databases. This is a .Net Core library to use the CDM v6 compliant databases.

## Install

```
PM> Install-Package omopcdmlib

```

## Usage

```
        var optionsBuilder = new DbContextOptionsBuilder<AppContext>();
        optionsBuilder.UseSqlite("Data Source=cdm-create.db");

            // AppContext from models
            using (var db = new AppContext(optionsBuilder.Options))
            {
                // Create vocab
                Console.WriteLine("Writing vocabulary");
                var vocab = new CreateVocab("/path/to/csv", db);
                vocab.Create(20); // Sample of 20 records. Omit to create full.

                // Create
                Console.WriteLine("Inserting a new Concept");
                db.Add(new Concept { 
                                    Id=22,
                                    ConceptId = 4523432,
                                    ConceptName = "My Concept", 
                                    VocabularyId = "SNOMED",
                                    ConceptClassId = "MyClass",
                                    ConceptCode = "MyCode",
                                    ValidStartDate = "2012-12-12",
                                    ValidEndDate = "2012-12-12",
                                    InvalidReason = "None",
                                    DomainId = "ASDF" });
                db.SaveChanges();

                // Read
                Console.WriteLine("Querying for a concept");
                var concept = db.Concept
                    .OrderBy(b => b.ConceptName)
                    .First();

                // Update
                Console.WriteLine("Updating the concept");
                concept.ConceptName = "new Concept";
                db.SaveChanges();

                // Delete
                Console.WriteLine("Delete the concept");
                db.Remove(concept);
                db.SaveChanges();

```

## Contributors

* [Bell Eapen](https://nuchange.ca)