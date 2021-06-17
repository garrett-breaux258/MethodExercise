using System;

namespace MethodExercise
{
    class Program
    {
        //___________Exercise 2_________________

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Difference(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int Division(int num1, int num2)
        {
            return num1 / num2;
        }

        public static decimal Modulus(decimal num1, decimal num2)
        {
            return num1 % num2;

        }

        public static int Sum(params int[] numbers)
        {
            var sum = 0;
            foreach (var num in numbers)
            {
                sum = sum + num;

            }
            return sum;
        }
        
        //public static int Sum(params int[] numbers)
        //{
        //  var sum = 0;
        //  foreach(var num in numbers)
        //  {
        //      sum = sum + num;
        //   }
        //      return sum;
        //}

        //public static in Sum(params int[] numbers)
        //{
        //  Var sum = 0
        //  foreach(var num in numbers)
        //  {
        //      sum = sum + num;
        //   }
        //      return sum;
        //}

        //public static int Sum(params int[] numbers)
        //{
        //  var sum = 0;
        //  foreach(var num in numbers)
        //  {
        //      sum = sum + num;
        //   }
        //      return sum;
        //}

        //public static int Sum(params int[] numbers)
        //{
        //  var sum = 0;
        //  foreach(var num in numbers)
        //  {
        //      sum = sum + num;
        //   }
        //      return sum;
        //}

        public static void SecurityQuestion1(string userName)
        {

            do
            {
                if (userName.ToUpper() == "GARRETT")
                { 
                    Console.WriteLine($"What is your favorite animal?");

                }
                else
                {
                    Console.WriteLine($"Only Garrett can access this computer");
                    Console.WriteLine("Enter your name again");
                    userName = Console.ReadLine();
                }

            } while (userName.ToUpper() != "GARRETT");
            

            
        }
        public static void AnimalSecurityQuestion2(string favoriteAnimal)
        {
            do
            {
                if (favoriteAnimal.ToUpper() == "MONKEY")
                {
                    Console.WriteLine($"What is your favorite color?");
                }
                else
                {
                    Console.WriteLine($"You can't sit with us anymore!");
                    Console.WriteLine($"But you can try again.");
                    favoriteAnimal = Console.ReadLine();
                }

            } while (favoriteAnimal.ToUpper() != "MONKEY");
                
                
        }
        public static void ColorSecurityQuestion3(string favoriteColor)
        {
            do
            {
                if (favoriteColor.ToUpper() == "BLACK")
                {
                    Console.WriteLine($"Dude,it's the best color, but final question." +
                                        $"What is your favorite band?");
                }
                else
                {
                    Console.WriteLine("Better luck next time.");
                    Console.WriteLine($"Try again.");
                    favoriteColor = Console.ReadLine();
                }
                
            } while (favoriteColor.ToUpper() != "BLACK");

        }
        public static void BandSecurityQuestion4(string favoriteBand)
        {
            do
            {
                if (favoriteBand.ToUpper() == "STATE CHAMPS")
                {
                    Console.WriteLine($"{favoriteBand} is best of all time");
                }
                else
                {
                    Console.WriteLine("You were so close");
                    Console.WriteLine($"Try again.");
                    favoriteBand = Console.ReadLine();
                }
              
            } while (favoriteBand.ToUpper() != "STATE CHAMPS");

        }
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(5, 10, 12, 24));
            Console.WriteLine(Add(12, 10));
            Console.WriteLine(Difference(45, 10));
            Console.WriteLine(Multiply(2, 4));
            Console.WriteLine(Division(16, 4));
            Console.WriteLine($" This is modulus: {Modulus(35.2m, 2)}");


            //-----------------Exerise 1-------------------

            Console.WriteLine($"Hello, what is your name?");

            string userName = Console.ReadLine();

            SecurityQuestion1(userName);

          
            string favoriteAnimal = Console.ReadLine();

            AnimalSecurityQuestion2(favoriteAnimal);
        
            string favoriteColor = Console.ReadLine();

            ColorSecurityQuestion3(favoriteColor);

            string favoriteBand = Console.ReadLine();

            BandSecurityQuestion4(favoriteBand);
            Console.WriteLine($"Congrats, {userName}. You have successfully accessed this computer by entering " +
                $"the correct answers to the security questions: {favoriteAnimal}, {favoriteColor}, and {favoriteBand}. Have a nice day!");

            
        }

    }
}
