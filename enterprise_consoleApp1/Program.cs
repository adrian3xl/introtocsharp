using System;

namespace enterprise_consoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            string gender;
            double salary;
            bool isemployed;

            Console.WriteLine("What is your name");
            name = Console.ReadLine();
           


            Console.WriteLine("please enter age");
            age = Convert.ToInt32 (Console.ReadLine());

            Console.WriteLine("Are you employed, True/False?");
            isemployed = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("please enter salary");
            salary = Convert.ToDouble(Console.ReadLine());
            

            Console.WriteLine("please enter gender");
            gender = Console.ReadLine();

            

            Console.WriteLine("Your name is " + name);

            Console.WriteLine("Your age is " + age);

            Console.WriteLine("Your salary is $ " + salary);

            Console.WriteLine("Gender is " + gender);

            Console.WriteLine("Do you work?" + isemployed);











        }
    }
}

