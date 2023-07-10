﻿namespace Lab01b_NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StartSequence();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Program completed.");
            }
        }

        static void StartSequence()
        {
            Console.Write("Enter a number greater than zero: ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[size];
            numbers = Populate(numbers);

            int sum = GetSum(numbers);
            int product = GetProduct(numbers, sum);
            decimal quotient = GetQuotient(product);

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Product: {product}");
            Console.WriteLine($"Quotient: {quotient}");
        }
        static int[] Populate(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Enter number {i + 1}/{numbers.Length}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            return numbers;
        }

        static int GetSum(int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
        }

        static int GetProduct(int[] numbers, int sum)
        {
            Console.WriteLine();
        }


        static decimal GetQuotient(int product)
        {
            Console.WriteLine();
        }

    }
}