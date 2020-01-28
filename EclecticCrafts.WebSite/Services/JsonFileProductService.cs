using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using EclecticCrafts.WebSite.Models;
using Microsoft.AspNetCore.Hosting;

namespace EclecticCrafts.WebSite.Services
{
    public class JsonFileProductService
    {
        public JsonFileProductService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }
    }
}

