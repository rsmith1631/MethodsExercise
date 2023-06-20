using System;
using System.Security.Cryptography.X509Certificates;

namespace MethodsExercise
{
 class Program
    {
        static void Main(string[] args)
        {
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
