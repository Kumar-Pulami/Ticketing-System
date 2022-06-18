using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Nepal_Recreation_Centre
{
    public static class Services
    {
       public static void Export(dynamic dataList, String _filePath)
        {
            String data = JsonConvert.SerializeObject(dataList);

            if (!File.Exists(_filePath))
            {
                var file = File.Create(_filePath);
                file.Close();
            }
            using (StreamWriter outputFile = new StreamWriter(_filePath))
            {
                outputFile.WriteLine(data);
                outputFile.Close();
            }
       }


        public static String Import(String _filePath)
        {
            string data = null;
            if (File.Exists(_filePath))
            {                
                data = File.ReadAllText(_filePath);
                return data;
            }
            else
            {
                MessageBox.Show("File Doesn't Exists.");
            }
            return null;
        }
    }
}
