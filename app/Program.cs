using System;
using System.Linq;
using omopcdmlib.Models;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {


            using (var db = new appContext())
            {
                // Create
                Console.WriteLine("Inserting a new Concept");
                db.Add(new Concept { ConceptName = "My Concept" });
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
