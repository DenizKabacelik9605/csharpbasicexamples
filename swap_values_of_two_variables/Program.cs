using System;

namespace swap_values_of_two_variables
{
    public class Program
    {
        static void Main(string[] args)
        {

            int num1, num2, temp;
            Console.WriteLine("Enter first  number");
            num1=Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Enter second  number");
            num2=Convert.ToInt32(Console.ReadLine());   
             Console.WriteLine($"number1: {num1}, number2: {num2}");
              temp=num1;
              num1=num2;
              num2=temp;
             Console.WriteLine("new number1: "+num1+" new number2: "+num2);
        }
    }
}
