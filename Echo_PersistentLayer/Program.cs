using Echo_PersistentLayer.Contexts;
using Echo_PersistentLayer.Entities.Util;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace Echo_PersistentLayer
{
    class Program
    {
        static void Main(string[] args)
        {

            string t2SmallConnectionString = ConnectionString();
            using (MySqlConnection conn = new MySqlConnection(t2SmallConnectionString))
            {
                // Create database if not exists
                using (T2SmallContext contextDB = new T2SmallContext(conn, false))
                {
                    contextDB.Database.CreateIfNotExists();
                }

                conn.Open();
                MySqlTransaction transaction = conn.BeginTransaction();

                try { 
                    using (T2SmallContext ctx = new T2SmallContext(conn, false))
                    {
                        ctx.Database.Log = (string message) => { Console.WriteLine(message); };
                        ctx.Database.UseTransaction(transaction);

                        DebugEntity de = new DebugEntity();
                        de.Msg = "Echo..";

                        ctx.DebugEntities.Add(de);

                        ctx.SaveChanges();
                    }

                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
            Console.ReadKey();
        }


        static string ConnectionString()
        {
            string pwd = "password" ;
            Console.Write("PWD: ");
            pwd = Console.ReadLine();


            var connectionString = "server=54.209.254.226;port=3306;database=dotnet2;uid=dotnet;password="+pwd+ ";Persist Security Info=True;";
            return connectionString;
        }
    }
}
