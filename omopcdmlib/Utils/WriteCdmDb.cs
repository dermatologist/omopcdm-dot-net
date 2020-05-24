using System.Collections.Generic;
using EFCore.BulkExtensions;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using omopcdmlib.Models;

namespace omopcdmlib.Utils
{
    public class WriteCdmDb<T> where T : class 
    {
        // https://github.com/borisdj/EFCore.BulkExtensions
        public void Write(List<T> entity, OmopCdmContext CdmContext)
        {
            
            if (CdmContext.Database.IsSqlite())
            {
                using (var connection = (SqliteConnection)CdmContext.Database.GetDbConnection())
                {
                    connection.Open();
                    using (var transaction = connection.BeginTransaction())
                    {
                        var bulkConfig = new BulkConfig() { SqliteConnection = connection, SqliteTransaction = transaction };
                        CdmContext.BulkInsert(entity, bulkConfig);
                        transaction.Commit();
                    }
                }
            }
            else
            {
                CdmContext.BulkInsert(entity);
                using (var transaction = CdmContext.Database.BeginTransaction())
                {
                    CdmContext.BulkInsert(entity);
                    transaction.Commit();
                }
                
            }

        }
    }
}