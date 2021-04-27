using System;

namespace LabAssignmentWeek2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Takes the First Number
           System.Console.WriteLine(" Welcome... What Number will you like to Divide \n Enter the First Number");
           var firstNumber = int.Parse(Console.ReadLine());

           //Takes the Second Number
           System.Console.WriteLine("Enter the Second Number");
           var secondNumber = int.Parse(Console.ReadLine());

           //Divides the the first number by the second number
           var result = firstNumber % secondNumber;

           //Print the division result
           System.Console.WriteLine("The remainder is " + result);
        }
    }
}
