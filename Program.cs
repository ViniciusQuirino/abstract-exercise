using System;
using System.Collections.Generic;
using System.Globalization;
using exercise_abstract.Entities;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Payer> list = new List<Payer>();
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Individual or company: ");
                char c = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (c == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, income, healthExpenditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    double numberOfEmployees = double.Parse(Console.ReadLine());
                    list.Add(new Company(name, income, numberOfEmployees));
                }
            }

            System.Console.WriteLine();
            System.Console.WriteLine("TAXES PAID:");
            double sum = 0;
            foreach (Payer item in list)
            {
                sum += item.Calculation();
                System.Console.WriteLine($"{item.Name}: $ {item.Calculation().ToString("F2", CultureInfo.InvariantCulture)}");
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}