using System;
using System.IO;

namespace Horoscope
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your favorite zodiac sign:");
            string userColor = Console.ReadLine();

            string output = GetLineFromfileData(userColor);

            if (output.Length != 0)
            {
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine("Sorry. zodiac sign not found");
            }

        }
        private static string[] ReadDataFromFile()
        {
            string directoryPath = @"C:\Users\opilane\samples";
            string fileName = "horoscope.txt";
            string fullPath = $@"{directoryPath}\{fileName}";

            string[] dataFromFile = File.ReadAllLines(fullPath);
            return dataFromFile;

        }

        private static string GetLineFromfileData(string userInput)
        {
            string[] dataFromFile = ReadDataFromFile();
            string result = "";

            foreach (string line in dataFromFile)
            {
                if (line.Contains(userInput))
                {
                    result = line;
                    break;
                }
            }

            return result;
        }
    }
}

