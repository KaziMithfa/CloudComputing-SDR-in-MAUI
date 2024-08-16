using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;
using MauiApp1.Models;
using System.Threading.Tasks;

namespace MauiApp1.Services
{
    public interface IConfigService
    {
        Task SaveConfigAsync(ConfigModel config);
        Task<ConfigModel> LoadConfigAsync();
    }

    public class ConfigService : IConfigService
    {
        private readonly string configFilePath = Path.Combine(FileSystem.AppDataDirectory, "config.json");

        //saving connection string in a locall json file
        public async Task SaveConfigAsync(ConfigModel config)
        {
            var json = JsonSerializer.Serialize(config);
            await File.WriteAllTextAsync(configFilePath, json);
        }

        public async Task<ConfigModel> LoadConfigAsync()
        {
            if (!File.Exists(configFilePath))
                return new ConfigModel();

            var json = await File.ReadAllTextAsync(configFilePath);
            return JsonSerializer.Deserialize<ConfigModel>(json);
        }
    }
}
