using System;
namespace program_to_add_two_numbers{

     public class Program{
        
      static void Main(string[] args){
        
       int num1;
       int num2;
       int total;
        
        Console.WriteLine("Enter first number");
        num1=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number");
        num2=int.Parse(Console.ReadLine());
        total=num1+num2;
     


       Console.WriteLine("Toplam " +total); //string and variable with write java
       Console.WriteLine("Toplam {0} ",total);//string and variable with write c
       Console.WriteLine($"Toplam {total}"); //string interpolation

      }


     }
}
