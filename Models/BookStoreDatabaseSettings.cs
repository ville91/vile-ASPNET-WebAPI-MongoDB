using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Vile_ASPNET_WebAPI_MongoDB.Models
{
    public class BookStoreDatabaseSettings
    {
        public string BookCollectionName { get; }
        public string ConnectionString { get; }
        public string DataBaseName { get; }

        public BookStoreDatabaseSettings()
        {
            DataBaseName = ConfigurationManager.AppSettings["MongoDbName"];
            ConnectionString = ConfigurationManager.AppSettings["MongoDbConnectionString"];
            BookCollectionName = ConfigurationManager.AppSettings["BookCollectionName"];
        }
    }

}