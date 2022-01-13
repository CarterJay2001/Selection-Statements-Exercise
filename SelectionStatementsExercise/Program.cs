using System;

namespace SelectionStatementsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 100);

            Console.WriteLine("Try to guess my favorite number between 1 and 100");

            var correct = false;
            var tries = 1;
            while (!correct)
            {
                int userinput = int.Parse(Console.ReadLine());

                if (userinput < favNumber)
                {
                    Console.WriteLine("\nToo low. Try Again:");
                    tries++;
                }
                else if (userinput > favNumber)
                {
                    Console.WriteLine("\nToo high. Try Again:");
                    tries++;
                }
                else
                {
                    correct = true;
                    Console.WriteLine($"\nYou got it in {tries} tries!!!");
                }

            }

            Console.WriteLine("\nWhat is your favorite school subject?");

            string favSubject = Console.ReadLine();

            switch (favSubject.ToLower())
            {
                case "science":
                    Console.WriteLine("\nI love Science. Have you ever made an accidental " +
                        $"explosion?");
                    break;

                case "math":
                    Console.WriteLine("\nI heard you like math, so what's the sum of U + Me?");
                    break;

                case "history":
                    Console.WriteLine("\nLike US History or World history? In my opinion one is WAYYY better than the other.");
                    break;

                case "english":
                    Console.WriteLine("\nNever understood the point, like, don't we already speak it?");
                    break;

                case "physical education":
                case "pe":
                case "p.e.":
                    Console.WriteLine("\nWell that's just everyone's favorite. I always wanted to play dodgeball, " +
                        "but alas I am only a computer :(");
                    break;

                case "lunch":
                    Console.WriteLine("\nNow we both know that doesn't count.");
                    break;

                default:
                    Console.WriteLine($"\nI don't think I've heard of {favSubject}. I'm sure it's fun though!");
                    break;
            }
        }
    }
}
