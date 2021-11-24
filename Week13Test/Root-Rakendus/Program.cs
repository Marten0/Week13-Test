using System;
using System.IO;

namespace Root_Rakendus
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\opilane\Samples\";

            Console.WriteLine("Enter directory  name:");
            string kasutajaKaust = Console.ReadLine();

            string newDirectoryFullPath = $@"{rootDirectory}\{kasutajaKaust}";
            bool directoryExists = Directory.Exists(newDirectoryFullPath);

            if (directoryExists)
            {
                Console.WriteLine($"{kasutajaKaust} already  exists in Samples.");
            }
            else
            {
                Directory.CreateDirectory(newDirectoryFullPath);
                Console.WriteLine($"Directory {kasutajaKaust} has been created.");
            }

            Directory.CreateDirectory(newDirectoryFullPath);


        }
    }
}
