using System;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Hello, what is your name?");

            string userName = Console.ReadLine();

            if(userName == "Garrett")
            {
                Console.WriteLine($"Hey Garrett, what's your favorite animal?");
            }
            else
            {
                Console.WriteLine($"Only Garrett can access this computer");

            }

            string favoriteAnimal = Console.ReadLine();

            if (favoriteAnimal == "Monkey")
            {
                Console.WriteLine($"Bro my favorite animal is also a {favoriteAnimal}," +
                    $"tell me what your favorite color is?");
            }
            else
            {
                Console.WriteLine($"You can't sit with us anymore!");

            }
            string favoriteColor = Console.ReadLine();
            if (favoriteColor=="Black")
            {
                Console.WriteLine($"Dude,it's the best color, but final question." +
                    $"What is your favorite band?");
            }
            else
            {
                Console.WriteLine("Better luck next time.");

            }
                
            string favoriteBand = Console.ReadLine();
            if (favoriteBand == "State Champs")
            {
                Console.WriteLine($"{favoriteBand} is best of all time");
            }
            else
            {
                Console.WriteLine("Do you feel lucky punk, do you?");
            }

            Console.WriteLine($"Congrats, {userName}. You have successfully accessed this computer by entering " +
                $"the correct answers to the security questions: {favoriteAnimal}, {favoriteColor}, and {favoriteBand}. Have a nice day!");
            }

    }
}
