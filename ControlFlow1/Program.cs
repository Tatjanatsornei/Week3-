using System;

namespace ControlFlow1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Personality test
            //пиложение просит пользователя ввести его любимый цвет
            //на основе введенного значения. консоль показывает пользователю некоторую обратную связь
            //red - you are so romantic
            //blue - you are a workaholic
            //green - you care about the environment
            //любое другое значение, то консоль выведет предложение "You are a {userinput} unicorn"
           
            Console.WriteLine("Please, enter yoy favorite color:");
            string userInput = Console.ReadLine().ToLower();

            if(userInput == "red")
            {
                Console.WriteLine("You are so romantic.");
            }
            else if(userInput == "blue")
            {
                Console.WriteLine("You are a workaholic.");
            }
            else if(userInput == "green")
            {
                Console.WriteLine("You care about the environment.");
            }
            else
            {
                Console.WriteLine($"You are a {userInput} unicorn.");
            }

            Console.WriteLine("Have a nice day!");
        }


    }
}
