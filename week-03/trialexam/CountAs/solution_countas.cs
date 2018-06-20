using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "afile.txt";
            string wrongPath = "not-a-file";

            Console.WriteLine(CountAsFromFile(path));
            Console.WriteLine(CountAsFromFile(wrongPath));

            Console.ReadLine();
        }

        public static int CountAsFromFile (string path)
        {
            int counter = 0;

            try
            {
                string content = File.ReadAllText(path).ToLower();

                for (int i = 0; i < content.Length; i++)
                {
                    if (content[i] == 'a')
                    {
                        counter++;
                    }
                }

                return counter;
            }
            catch (FileNotFoundException)
            {
                return 0;
            }
        }
    }
}
