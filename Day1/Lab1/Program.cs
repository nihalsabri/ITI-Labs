using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // area of rectangle 
            Console.WriteLine("Enter Height of Rect");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter width of Rect");
            int width = int.Parse(Console.ReadLine());
            if (height <= 0 || width <= 0)
            {
                Console.WriteLine("Enter valid number");
               
            }
            int area = width * height;
            Console.WriteLine($"The Area of the Reactangle = {area} ");

            // - Write a program that reads a person's age and classifies them as Child (0-12), Teenager (13-19), Adult (20-64), Senior (65+)
            Console.WriteLine("Enter Age");
            int age = int.Parse(Console.ReadLine());

            if (age > 0 && age <= 12)
            {
                Console.WriteLine("YOU 're Child");
            }
            else if (age > 12 && age <= 19)
            {
                Console.WriteLine("YOU 're Teenager");
            }
            else if (age > 19 && age <= 64)
            {
                Console.WriteLine("YOU 're Adult");
            }
            else if (age > 64)
            {
                Console.WriteLine("YOU 're senior");
            }
            else
            {
                Console.WriteLine("The number is invalid");
            }

            // - Write a program that calculates factorial of a number
            Console.WriteLine("Enter Num to Calculate Factorial");
            int num = int.Parse(Console.ReadLine());
            int fact = 1;
            for (int i = 5; i >= 1; i--)
            {
                fact *= i;

            }
            Console.WriteLine($"factorial2 = {fact}");


            //// calculator
            
             int operation;
             do
             {
                 Console.WriteLine("Enter Your operation num");
                 Console.WriteLine("1- addition / 2- sub / 3 - mul / 4 - division / 5- % modulus / 6- exist");

                  operation = int.Parse(Console.ReadLine());

                 Console.WriteLine("Enter num1");
                 int num1 = int.Parse(Console.ReadLine());


                 Console.WriteLine("Enter num1");
                 int num2 = int.Parse(Console.ReadLine());


                 switch (operation)
                 {
                     case 1:
                         int sum = num1 + num2;
                         Console.WriteLine($"sum = {sum}");
                         break;
                     case 2:
                         int sub = num1 - num2;
                         Console.WriteLine($"sub = {sub}");
                         break;
                     case 3:
                         int mul = num1 * num2;
                         Console.WriteLine($"mul = {mul}");
                         break;
                     case 4:
                         int div = num1 / num2;
                         Console.WriteLine($"div = {div}");

                         if (num2 == 0)
                         {
                             Console.WriteLine("change the value zero and try again");
                             continue;
                         }
                         break;
                     case 5:
                         int mod = num1 % num2;
                         Console.WriteLine($"mod = {mod}");
                         break;
                     default:
                         Console.WriteLine("Select Correct operation");
                         break;


                     }
                 }  while (operation != 6);
             

            /// BONUS :) 
            /// 	
            //      *
            //     **
            //    ***
            //   ****
            //  *****
            for (int i = 1; i <= 6; i++)
            {
                for (int j = i; j <=6 ; j++)
                {
                    Console.Write("  ");
                }

                for (int n = 1; n <= i; n++)
                {
                    Console.Write(" #");
                }
                Console.WriteLine();
            }




            Console.WriteLine("HEREEEE");
        




        }
}
}