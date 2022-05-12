using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp
{
    public class LINQ_vs_Normal
    {
        static void LINQPrintArrayOfNames()
        {
            string[] countries = { "NIGERIA", "TOGO", "GHANA", "CHINA", "UK" };

            string result = countries.Aggregate((a, b) => a + ", " + b);
            Console.WriteLine("Countries are: " + result);
            Console.ReadLine();
        }
        static void PrintArrayOfNames()
        {
            string[] countries = { "NIGERIA", "TOGO", "GHANA", "CHINA", "UK" };

            string country = null;
            foreach (var item in countries)
            {
                country = country + item + ", ";
            }

            int lastIndexOfComma = country.LastIndexOf(",");
            country = country.Remove(lastIndexOfComma);
            Console.WriteLine("The location of comma after UK is: " + lastIndexOfComma);
            Console.WriteLine("Countries are: " + country);
            Console.ReadLine();
        }
        static void LINQPrintShortestNameInAList()
        {
            string[] countries = { "NIGERIA", "TOGO", "GHANA" };

            int? size = countries.Min(x => x.Length);

            Console.WriteLine("The Length of the shortest name is: " + size);
        }

        static void PrintShortestNameInAList()
        {
            string[] countries = { "NIGERIA", "TOGO", "GHANA" };

            int? size = null;

            foreach (var item in countries)
            {
                if (!size.HasValue || size > item.Length)
                {
                    size = item.Length;
                }
            }
            Console.WriteLine("The Length of the shortest name is: " + size);
        }

        static void LINQPrintOtherAgregrate()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int sum = numbers.Sum();
            int cnt = numbers.Count();
            double avg = numbers.Average();
            double avgEven = numbers.Where(x => x % 2 == 0).Average();
            int sumEven = numbers.Where(x => x % 2 == 0).Sum();

            Console.WriteLine("Agregrate Values, Sum: " + sum + ", Count: " + cnt
                + ", Sum Even: " + sumEven + ", Average: " + avg + ", avgEven " + avgEven);
        }

        static void LINQPrintEvenNumbers()
        {
            int[] numbers = { 1, 3, 4, 5, 6, 7, 8, 9, 10 };

            int result = numbers.Where(x => x % 2 == 0).Min();

            Console.WriteLine(result);
        }
        static void LINQPrintLeastEvenNumbers()
        {
            int[] numbers = { 1, 3, 4, 5, 6, 7, 8, 9, 10 };

            int result = numbers.Where(x => x % 2 == 0).Min();

            Console.WriteLine(result);
        }

        static void LINQPrintMinimumNumber()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int result = numbers.Min();

            Console.WriteLine(result);
        }

        static void PrintMinimumNumber()
        {
            int[] numbers = { 11, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int? result = null;

            foreach (int num in numbers)
            {

                if (!result.HasValue || num < result)
                {
                    result = num;
                }

            }
            Console.WriteLine(result);
        }
        static void PrintEvenNumbers()
        {
            int[] numbers_ = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach (int item in numbers)
            {
                if (item % 2 == 0)
                {
                    Console.WriteLine(item);
                }
            }

        }
    }
}
