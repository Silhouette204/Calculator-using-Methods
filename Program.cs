using System;

namespace methodsReturnCalculator // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int num1, num2;
          char op;
            Console.WriteLine("=====Simple Calculator=====");

            Console.WriteLine("Enter First Number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("=====Choose Operators=====");
            Console.WriteLine("A. Addition S. Subtraction D. Division M. Multiplication O. Modulo");

            op = Convert.ToChar(Console.ReadLine());

            if (op == 'A'){
             Console.WriteLine("It's Addition");
             Console.WriteLine(addition(num1, num2));
            
            } else if (op == 'S'){
             Console.WriteLine("It's Subtraction");
             Console.WriteLine(subtractiton(num1, num2));
            
            } else if (op == 'D'){
             Console.WriteLine("It's Division");
             Console.WriteLine(subtractiton(num1, num2));

            } else if (op == 'M'){
             Console.WriteLine("It's Multiplication");
             Console.WriteLine(subtractiton(num1, num2));

            } else if (op == 'O'){
             Console.WriteLine("It's Modulo");
             Console.WriteLine(subtractiton(num1, num2));
            }        
        }

     public static int addition(int num1, int num2){
      return num1 + num2;
     }

     public static int subtractiton(int num1, int num2){
       return num1 - num2;
     }

     public static int Division(int num1, int num2){
       return num1 / num2;
     }

     public static int Multiplication(int num1, int num2){
       return num1 * num2;
     }

    public static int Modulo(int num1, int num2){
       return num1 % num2;
     }
    }
}
