using System;

namespace SelectionStatementsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 1000);

            Console.WriteLine("Try to guess my favorite number");
            var userinput = int.Parse(Console.ReadLine());

            if (userinput < favNumber)
            {
                Console.WriteLine("Too low");
            }
            else if (userinput > favNumber)
            {
                Console.WriteLine("Too high");
            }
            else if (userinput == favNumber)
            {
                Console.WriteLine("You Got It!!!");
            }
            else
            {
                Console.WriteLine("Nevermind");
            }

            Console.WriteLine("\nWhat is your favorite school subject? (in pascal case)");

            string favSubject = Console.ReadLine();

            switch (favSubject)
            {
                case "Science":
                    Console.WriteLine("\nI love Science. Have you ever made an accidental " +
                        $"explosion?");
                    break;

                case "Math":
                    Console.WriteLine("\nI heard you like math, so what's the sum of U + Me?");
                    break;

                case "History":
                    Console.WriteLine("\nLike US History or World history? In my opinion one is WAYYY better than the other.");
                    break;

                case "English":
                    Console.WriteLine("\nNever understood the point, like, don't we already speak it?");
                    break;

                case "Physical Education":
                case "PE":
                case "P.E.":
                    Console.WriteLine("\nWell that's just everyone's favorite. I always wanted to play dodgeball, " +
                        "but alas I am only a computer :(");
                    break;

                case "Lunch":
                    Console.WriteLine("\nNow we both know that doesn't count.");
                    break;

                default:
                    Console.WriteLine($"\nI don't think I've heard of {favSubject}. I'm sure it's fun though!");
                    break;
            }
        }
    }
}
