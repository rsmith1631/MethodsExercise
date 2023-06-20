using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace MethodsExercise
{
    class Program
    {
        public static int Sum(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;
        }

        public static int Multiply(int num1, int num2, int num3)
        {      var amount = num1 * num2 * num3;
               return amount;

        }

        static void Main(string[] args)
        {

            var amountOfCars = Sum(2, 6);
            var amount = Multiply(55, 37, 21);

            Console.WriteLine("What is your first name?");
             var userName = Console.ReadLine(); // input

            Console.WriteLine($"Hi {userName} What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine("That's awesome! What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine("That's great! Lastly what is your favorite band?");
            var band = Console.ReadLine();

            Console.WriteLine("That's great! Thank you for taking time to fill out our form!");
            
            Console.WriteLine($"{userName}, here is your profile:");
            Console.WriteLine($"---------------------------------------------------");



            Console.WriteLine($"Name: {userName}");
            Console.WriteLine($"Color: {color}");
            Console.WriteLine($"Animal: {animal}");
            Console.WriteLine($"Band: {band}");

        }
    }
}
