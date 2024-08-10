using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Models
{
    public class ConfigModel
    {
        public string StorageAccountName { get; set; }
        public string StorageAccountKey { get; set; }
        public string FileContainerName { get; set; }
        public string ImageContainerName { get; set; }
        public string ConnectionString => $"DefaultEndpointsProtocol=https;AccountName={StorageAccountName};AccountKey={StorageAccountKey};EndpointSuffix=core.windows.net";
    }
}
