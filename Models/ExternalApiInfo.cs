using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Vile_ASPNET_WebAPI_MongoDB.Models
{
    public class ExternalApiInfo
    {
        public string EndPoint { get; }

        public ExternalApiInfo()
        {
            EndPoint = ConfigurationManager.AppSettings["ExternalApiEndPoint"];
        }

    }
}