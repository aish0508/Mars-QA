﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_CompetitionTask2.Data
{
    public class EducationDataHelper
    {
        public static List<EducationData> ReadEducationData(string jsonFileName)
        {
            string currentDirectory = "C:\\Users\\owner\\OneDrive\\Documents\\Mars-QA\\MarsQA-CompetitionTask2\\MarsQA-CompetitionTask2";
            string filePath = Path.Combine(currentDirectory, "Data", jsonFileName);
            string jsonContent = File.ReadAllText(filePath);

            return JsonConvert.DeserializeObject<List<EducationData>>(jsonContent) ?? new List<EducationData>();
        }
    }
}
