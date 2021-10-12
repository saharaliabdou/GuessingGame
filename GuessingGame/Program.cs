using System;

namespace GuessingGame // A gauessing game where the user can guess a number between 1 ans 10. 
{
    class Program
    {

        static void Main(string[] args)
        {

            int counter = 0;
            bool stopthegame = false;

            int random_number = new Random().Next(1, 10);
            while (!stopthegame)
            {
                Console.WriteLine("Please chose an integer between 1 and 10");
                counter++;
                string chosen_number = Console.ReadLine();
                int chosenInt = int.Parse(chosen_number);

                if (chosenInt < random_number)
                {
                    Console.WriteLine($"Your chosen number is smaller than secret number ");

                }


                else if (chosenInt > random_number)
                {
                    Console.WriteLine($"Your chosen number is larger than secret number.");

                }



                else if (chosenInt == random_number)
                {
                    Console.WriteLine($"Your chosen number is the same as the secret number, which is {random_number}! You made it  {counter} tries!");
                    Console.WriteLine("Would you like to play again?");
                    Console.WriteLine("Press Y or y to continue");
                   string continueGame = Console.ReadLine();
                    if (continueGame != "Y" || continueGame !="y")
                    

                        stopthegame = false;
                    else {
                        stopthegame = true;
                            }
                    }

                
                   
                    
                }
                
            }

            



        }
    }


