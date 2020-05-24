using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Text;
using omopcdmlib.Models;

/**
Required for migrations to work
*/
namespace app
{
    public class AppContext : OmopCdmContext
    {
        public AppContext()
        {
        }

        public AppContext(DbContextOptions<AppContext> options)
        {
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("DataSource=cdm-create.db");
            }
        }

    }
}