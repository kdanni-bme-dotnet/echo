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
                conn.Open();

                using (T2SmallContext ctx = new T2SmallContext(conn, false))
                {
                    DebugEntity de = new DebugEntity();
                    de.Msg = "Echo..";

                    ctx.DebugEntities.Add(de);

                    ctx.SaveChanges();
                }
            }
            Console.ReadKey();
        }


        static string ConnectionString()
        {
            string pwd = "password" ;
            Console.Write("PWD: ");
            pwd = Console.ReadLine();


            var connectionString = "server=54.209.254.226;port=3306;database=dotnet;uid=dotnet;password="+pwd+";";
            return connectionString;
        }
    }
}
