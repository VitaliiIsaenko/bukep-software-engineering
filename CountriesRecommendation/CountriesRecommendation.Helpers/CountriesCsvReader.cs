using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CountriesRecommendation.Helpers
{
    public class CsvReader
    {
        public static string[][] Read(string fileName)
        {
            var curr = Directory.GetParent(Directory.GetCurrentDirectory()).Parent;
            var filePath = $"{curr}/countries/{fileName}";
            
            var lines = File.ReadAllLines(filePath).Skip(1).ToArray();
            string[][] rows = new string[lines.Length][];
            for (int i = 0; i < lines.Length; i++)
            {
                var fields = lines[i].Split(",");
                rows[i] = fields;
            }
            return rows;
        }
    
        // Перегрузка метода Read()
        // принимает массив названий файлов
        // возвращает все строки из всех файлов
        public static string[][] Read(string[] fileNames)
        {
            // Здесь мы используем структуру данных список, для создания списка списков 
            List<List<string>> allRows = new List<List<string>>();
            foreach(var fileName in fileNames) {
                foreach(var row in CsvReader.Read(fileName)) {
                    allRows.Add(new List<string>(row));
                }
            }
            return allRows.Select(ar => ar.ToArray()).ToArray();
        }
    }
}