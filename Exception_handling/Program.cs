using System;

namespace Exception_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int results;

            Console.WriteLine("please enter a number");
            num1 =int.Parse( Console.ReadLine());
            

            Console.WriteLine("please enter a econd number");
            num2 = int.Parse(Console.ReadLine());

            try
            {
                results = num1 / num2;
                Console.WriteLine("result is " + results);
            }
            catch (Exception)
            {

                Console.WriteLine("operation failed"); 
            }

        }
    }
}
