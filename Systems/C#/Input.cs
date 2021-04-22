using System;

// menu based program to add two numbers and condunt mathematical oprations according to the user

namespace Learning
{
    class Input
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Enter 2 numbers");
          
          double a = Convert.ToDouble(Console.ReadLine()); //Console.ReadLine() is used for entering strings and Convert.ToDouble converts the string literal to an integer  
          double b = Convert.ToDouble(Console.ReadLine());
          
          Console.WriteLine("Enter Add to add the two the numbers, Subtract to subtract b from a, Multiply to multiply the two and Divide to divide a by b");
          string choice = Console.Readline();
          double result;
          
          if (choice.equals("Add"))
          { 
            result = a + b;
            Console.WriteLine("Sum is = " + result);
          }
          
          else if (choice.equals("Subtract"))
          {
            result = a - b;
            Console.WriteLine("Result is = " + result);
          }
          
          else if (choice.equals("Multiply"))
          {
            result = a * b;
            Console.WriteLine("Product is = " + result);
          }
          
          else if (choice.equals("Divide"))
          {
            result = a / b;
            Console.WriteLine("Quotient is = " + result);
          }
          
          else
          {
            Console.WriteLine("Invalid Choice");
          }
      }
   }
}
