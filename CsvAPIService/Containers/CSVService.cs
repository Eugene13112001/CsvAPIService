using CsvHelper;
using System.Collections;
using System.Globalization;
using System.IO;
using CsvAPIService.Models;
using static System.Net.Mime.MediaTypeNames;
using DnsClient.Protocol;

namespace CsvAPIService.Containers
{
    public interface ICSVServiceReader
    {
        public Task<CsvModel> ReadCSV (Stream file);
    }
    public class CSVServiceReader : ICSVServiceReader
    {
        public async Task<CsvModel>  ReadCSV (Stream file)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(file))
            {
                string? line;
                while ((line = await reader.ReadLineAsync()) != null)
                {

                    string[] words = line.Split(new char[] { ',' });

                    count += 1;
                }
            }
            return records;
        }
    }

    public interface ICSVServiceWriter
    {
        public Task<string> WriteCSV(string text, string path);
    }
    public class CSVServiceWriter : ICSVServiceWriter
    {
        public async Task<string> WriteCSV(string text , string path)
        {

            // полная перезапись файла 
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                await writer.WriteLineAsync(text);
            }
            
            return path;
        }
    }
}
