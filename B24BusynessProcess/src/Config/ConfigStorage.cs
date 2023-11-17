using System;
using System.Text.Json;

namespace B24BusynessProcess.Config
{
    internal static class ConfigStorage
    {
        private const string PATH_TO_FILE_DEFAULT = "./config.json";

        public static void Save(Config? config, string pathToFile = PATH_TO_FILE_DEFAULT)
        {
            if (config == null)
                return;

            var configJson = JsonSerializer.Serialize(config);
            using var file = File.CreateText(pathToFile);
            file.Write(configJson);
        }

        public static Config Load(string pathToFile = PATH_TO_FILE_DEFAULT)
        {
            try
            {
                using var file = File.OpenText(pathToFile);
                var configJson = file.ReadToEnd();
                return JsonSerializer.Deserialize<Config>(configJson) ?? new Config();
            }
            catch (System.IO.FileNotFoundException)
            {
                return new Config();
            }
            catch(System.Text.Json.JsonException)
            {
                return new Config();
            }
        }
    }
}
