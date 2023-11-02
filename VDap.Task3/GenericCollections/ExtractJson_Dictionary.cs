using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace VDap.Task3.GenericCollections
{
    public class ExtractJson_Dictionary
    {
        public static Dictionary<string,string> data = new Dictionary<string,string>();
        public static void ExtractAndShow()
        {
            FileStream file = File.OpenRead("../Data.Json");
            StreamReader reader = new StreamReader(file);
            string json = reader.ReadToEnd();
            reader.Close();
            data = JsonSerializer.Deserialize<Dictionary<string,string>>(json);
            foreach(var i in data)
            {
                Console.WriteLine($"Key is :{i.Key} and value is : {i.Value}");
            }
        }
    }
}
