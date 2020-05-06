﻿using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Text;
using omopcdmlib.Models;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {


        var optionsBuilder = new DbContextOptionsBuilder<OmopCdmContext>();
        optionsBuilder.UseSqlite("Data Source=app.db");

            using (var db = new OmopCdmContext(optionsBuilder.Options))
            {
                // Create
                Console.WriteLine("Inserting a new Concept");
                db.Add(new Concept { ConceptName = "My Concept", 
                                    ConceptId = 1, 
                                    VocabularyId = "SNOMED",
                                    ConceptClassId = "MyClass",
                                    ConceptCode = "MyCode",
                                    ValidStartDate = Encoding.ASCII.GetBytes("2012-12-12"),
                                    ValidEndDate = Encoding.ASCII.GetBytes("2012-12-12"),
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
                // concept.Posts.Add(
                //     new Post
                //     {
                //         Title = "Hello World",
                //         Content = "I wrote an app using EF Core!"
                //     });
                db.SaveChanges();

                // Delete
                Console.WriteLine("Delete the concept");
                db.Remove(concept);
                db.SaveChanges();
            }
        }
    }
}
