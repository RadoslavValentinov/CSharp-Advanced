using System;
using System.IO;

namespace Line_Numbers_Exc
{
    class Program
    {
        static void Main(string[] args)
        {

            string inputText = "../../../text.txt";
            string resultText = "../../../result.txt";
            using (StreamWriter writeText = new StreamWriter(resultText))
            {
                using (StreamReader resdertext = new StreamReader(inputText))
                {
                    string lineOfText = resdertext.ReadLine();
                    int count = 1;
                    while (lineOfText !=null)
                    {
                        writeText.WriteLine($"Line {count}: {lineOfText}");
                        count++;
                        lineOfText = resdertext.ReadLine();
                    }
                }
            }

        }
    }
}
