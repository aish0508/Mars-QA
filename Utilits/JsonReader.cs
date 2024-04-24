using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTaskPart1.Utilits
{
    public class JsonReader
    {
        public static List<T> LoadData<T>(string jsonFileName)
        {
            string currentDirectory = "C:\\Users\\owner\\OneDrive\\Documents\\Mars-QA\\MarsQA-Advanced Task\\Advanced Task Part1\\AdvancedTaskPart1\\AdvancedTaskPart1";
            //C:\Users\owner\OneDrive\Documents\Mars-QA\MarsQA-Advanced Task\Advanced Task Part1\AdvancedTaskPart1\AdvancedTaskPart1\JsonData\addLanguageData.json
            string filePath = Path.Combine(currentDirectory, "JsonData", jsonFileName);
            Thread.Sleep(2000);
            using (StreamReader reader = new StreamReader(filePath))
            {
                var jsonContent = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<List<T>>(jsonContent);
            }
        }
    }
}
