using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Vile_ASPNET_WebAPI_MongoDB.DataAccess
{
    public class ProductManagementDbContext : DbContext
    {
        public ProductManagementDbContext() : base("name=MyDatabaseConnection")
        {

        }
    }
}