using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class Logging
    {

        public void TextToSreen(String text)
        {
            Console.WriteLine($"{DateTime.Now} : {text}");

        }
        public void TextToFile(string text)
        {
            string date = DateTime.Now.ToString("yyyy-MM-dd");

            //logs in a file a log with the StreamWriter object and his functions.
            using (StreamWriter sw = new StreamWriter(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"Logs/{date}.log"), true))
            {

                sw.WriteLine($"{DateTime.Now}: {text}");
            }

        }
    }
}
