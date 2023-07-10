namespace Lab01b_NumbersGame
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
            Console.WriteLine();
        }

        static int GetSum(int[] numbers)
        {
            Console.WriteLine();
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