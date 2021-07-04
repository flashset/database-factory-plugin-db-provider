using DataStore.Resolver;
using System;
using System.Configuration;

namespace DataStore.Service
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = ConfigurationManager.AppSettings["ConnectionString"];

            DataResolver.RegisterResolver();

            var db = DataResolver.GetInstance<DbProvider>();

            using (var conn = db.Connection(connectionString))
            {
                conn.Open();

                using (var cmd = db.Command("delete from Employee", conn))
                {
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }

            Console.Read();
        }
    }
}
