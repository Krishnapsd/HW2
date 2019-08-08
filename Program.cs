using System;
//Write a program that asks for three integers
//Compare them and display the largest number and the smallest number
namespace HW_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int num3;
            string entry;


            Console.WriteLine("Enter the Number");
            num1 = num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the next Number");
            entry = Console.ReadLine();

            while (entry != "E")
            {
                num3 = Convert.ToInt32(entry);

                if (num3 > num1)
                {
                    num1=num3;
                }
                else if (num3 > num2)
                {
                    num2=num3;
                }
                Console.WriteLine("Enter the Number or Exit");
                entry = Console.ReadLine();

                }
            Console.WriteLine("The Largest number is : " + num1 + " . ");
            Console.WriteLine("The Smallest number is : " + num2 + " . ");
            Console.ReadLine();
        }
    }
}
