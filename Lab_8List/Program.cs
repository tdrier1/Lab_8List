using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            do
            {
                List<double> AtBats = new List<double>();
                double success = 0;
                double sum = 0;

                Console.WriteLine("Welcome to Batting Average Calculator!");
                Console.Write("\nEnter the number of times at bat:");
                int input = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\n");
                Console.WriteLine("0=out, 1=single, 2=double, 3=triple, 4=homerun");

                for (int i = 0; i < input; i++)
                {
                    Console.Write("Result for At-Bat " + (i + 1) + ": ");
                    sum = Convert.ToInt32(Console.ReadLine());

                    AtBats.Add(sum);
                }

                for (int f = 0; f < AtBats.Count; f++)
                {
                    if (AtBats[f] > 0)
                    {
                        success++;
                        sum = sum + AtBats[f];
                    }
                }

                double BA = success / AtBats.Count;
                double SP = sum / AtBats.Count;

                Console.WriteLine("\nBatting Avg: " + BA.ToString("#.000"));
                Console.WriteLine("\nSlugging Percentage: " + SP.ToString("#.000"));

                Console.WriteLine("\n\nDo you want to cont?(y/n)");
                String cont = Console.ReadLine();

                if (cont == "n")
                {
                    run = false;
                }


            } while (run == true);

        }
    }
}