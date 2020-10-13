using System;

namespace CampbellLab3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = false;
            Console.WriteLine("Hello! What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Thanks, {userName}!");
            do
            {
                Console.WriteLine($"{userName} please pick a number between 1 and 100!");
                int userRoll = int.Parse(Console.ReadLine());
                decisionMaker(userRoll);
            } while (playAgain == true);
            void decisionMaker(int _userRoll) 
            {
                if (_userRoll < 1)
                {
                    Console.WriteLine($"Sorry, your number of {_userRoll} is invalid. Please provide a number between 1-100");
                    playAgain = true;
                    return;
                }
                if (_userRoll % 2 == 0 && _userRoll > 60)
                {
                    Console.WriteLine($"{_userRoll} Even");
                }
                else if (_userRoll % 2 != 0 && _userRoll > 60)
                {
                    Console.WriteLine($"{_userRoll} Odd");
                }
                else if (_userRoll % 2 == 0 && _userRoll > 25)
                {
                    Console.WriteLine("Even");
                }
                else if (_userRoll % 2 == 0 && _userRoll > 1)
                {
                    Console.WriteLine("Even and less than 25");
                }
                else if (_userRoll % 2 != 0)
                {
                    Console.WriteLine($"{_userRoll} Odd");
                }
                Console.WriteLine($"{userName}, would you like to play again? Y/N");
                string userChoice = Console.ReadLine();
                if (userChoice == "y")
                {
                    playAgain = true;
                }
                else 
                {
                    playAgain = false;
                }
            }

        }
    }
}
