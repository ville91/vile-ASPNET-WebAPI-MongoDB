using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vile_ASPNET_WebAPI_MongoDB.Models
{
        public class SlideInfo
        {
            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("createdAt")]
            public string CreatedAt { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("image")]
            public string ImageUrl { get; set; }
        }
}