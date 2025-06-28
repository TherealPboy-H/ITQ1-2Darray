using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITQ1_2Darray
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Greenhouse Temperature Monitoring System\n");

            Console.Write("Enter the number of sections: ");
            int numSections = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of readings per section: ");
            int numReadings = int.Parse(Console.ReadLine());

            // 2D array: rows = sections, columns = readings per section
            int[,] temperatures = new int[numSections, numReadings];

            for (int section = 0; section < numSections; section++)
            {
                Console.WriteLine($"\nEnter the temperature readings for section {section + 1}:");

                for (int reading = 0; reading < numReadings; reading++)
                {
                    Console.Write($"Reading {reading + 1}: ");
                    temperatures[section, reading] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nSensor Data:");
            DisplayAll(temperatures);
            Console.ReadLine();
        }

        private static void DisplayAll(int[,] temps)
        {
            int sections = temps.GetLength(0);
            int readings = temps.GetLength(1);

            for (int i = 0; i < sections; i++)
            {
                Console.WriteLine($"\nSection {i + 1}:");
                for (int j = 0; j < readings; j++)
                {
                    Console.WriteLine($"Reading {j + 1}: {temps[i, j]}");
                }
            }



        }
    }
}
