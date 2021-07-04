using MSSqlProvider;
using MySqlProvider;
using System.Configuration;
using Unity;

namespace DataStore.Resolver
{
    public  class DataResolver
    {    
        static IUnityContainer container;
        public static void RegisterResolver()
        {
            // container instance
            container = new UnityContainer();

            string DbProviderPlugin = ConfigurationManager.AppSettings["DbProviderPlugin"];
            switch (DbProviderPlugin.ToUpper())
            {
                case "MSSQL":
                     container.RegisterType<IDbProvider, MSSQLConnector>();
                    break;

                case "MYSQL":
                    container.RegisterType<IDbProvider, MySQLConnector>();
                    break;
            } 
        }

        public static T GetInstance<T>()
        {
            return container.Resolve<T>();
        }
    }
}
