using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring varibles
            int foodApples = 0;
            int gold = 10;
            int hunger = 5;
            var ran = new Random();
            var ran2 = new Random();
            int runs = 0;
            //Waiting for the user to begin
            Console.WriteLine("\nThe Apple Store!!");
            Console.WriteLine("\nPress Enter to Begin!!!");
            Console.ReadKey();
            //Instuctions
            Console.WriteLine("\n INSTRUCTIONS \n----------------------------------------");
            Console.WriteLine("Press S to look at your status");
            Console.WriteLine("Press A to buy an apple, but you will lose a Gold Coin!");
            Console.WriteLine("Press E to eat an apple");
            Console.WriteLine("Be careful to only hit keys that you want to hit, or\nelse you'll get more hungry faster!");
            //Setting up the story
            Console.WriteLine("You need to buy some apples for your apple pie");
            //Process of buying apples and eating apples
            while (foodApples < 7)
            {
                //Increases runs each time the while loop runs through
                runs++;
                //This if statement makes it so that the robbery can only happen after the second run.
                if (runs != 1)
                {
                    //Begining of the robbery
                    var robbed = ran.Next(5);
                    if (robbed == 0)
                    {
                        Console.WriteLine("\nSomeone robs you!! \nDo you try and chase down the gold or just let him go?");
                        Console.WriteLine("Press Y for yes to chase him down or N to not chase him down");
                        //User saying Yes to attempt to catch the robber.
                        if (Console.ReadKey().Key == ConsoleKey.Y)
                        {
                            //Makes you a bit more hungry (naturlly trying to chase a robber) and delcares the new random varible to determine
                            //wether or not the user succeds in catching the robber.
                            hunger--;
                            var chase = ran2.Next(2);
                            if (chase == 0)
                            {
                                //Succes in catching the robber
                                Console.WriteLine("\nYou succed in catching the robber. You loose no Gold");
                                if (hunger <= 0)
                                {
                                    break;
                                }
                            }
                            else
                            {
                                //Failed to catch the robber
                                Console.WriteLine("\nHe gets away and you lose two gold!");
                                gold -= 2;
                                if (hunger <= 0)
                                {
                                    break;
                                }
                                if (gold <= 0)
                                {
                                    break;
                                }
                            }
                        }
                        //User said no to try and catch the robber
                        else
                        {
                            Console.WriteLine("\nYou watch him run off. You lose two gold!");
                            gold -= 2;
                            if (gold <= 0)
                            {
                                break;
                            }
                        }
                    }
                }
                //Warning the user is getting hungery
                if(hunger == 3 || hunger == 2)
                {
                    Console.WriteLine("You are getting a little bit hungry.");
                }
                //Forcing the user to eat an apple...
                if(hunger == 0)
                {
                    Console.WriteLine("You're about to die of hunger you must eat!!");
                }
                //... And if the user doesn't eat the apple the user dies
                if(hunger < 0)
                {
                    break;
                }
                //If you run out of gold you also lose. GOING TO CHANGE
                if(gold == 0)
                {
                    break;
                }
                //The three actions E Eat A Buy and S Status
                var keyRead1 = Console.ReadKey().Key;
                if (keyRead1 == ConsoleKey.E)
                {
                    if (foodApples > 0)
                    {
                        foodApples--;
                        hunger++;
                        hunger++;
                        Console.WriteLine("\nYour hunger has been brought back by two!");
                    }
                    else
                    {
                        Console.WriteLine("\nYou search through your bag and find that you have no apples!");
                    }
                }
                //Buying an apple
                if (keyRead1 == ConsoleKey.A)
                {
                    if (gold > 0)
                    {
                        Console.WriteLine("\nYou buy an apple");
                        gold--;
                        hunger--;
                        foodApples++;
                        Console.WriteLine("Your gold:" + gold + "\n Your Apples:" + foodApples);
                    }
                    else
                    {
                        Console.WriteLine("\nYou look through your bag and find no gold!! What will you do. You little cheater how did you get this message");
                        Console.WriteLine("...Well since you did here is 100 gold!");
                        gold += 100;
                    }
                }
                //Checking for S to look at the user's status.
                if (keyRead1 == ConsoleKey.S)
                {
                    Console.WriteLine("\nHunger: " + hunger);
                    Console.WriteLine("Gold: " + gold);
                    Console.WriteLine("Apples: " + foodApples);
                }
                //Atempt to tell user that they hit a wrong key BROKEN
                /*if(keyRead1 != ConsoleKey.S || keyRead1 != ConsoleKey.A || keyRead1 != ConsoleKey.E)
                {
                    Console.WriteLine("You hit a wrong key!)";
                }*/
            }
            if(gold == 0)
            {
                Console.WriteLine("\n \nAs you walk home you think of a way to explaning to your family why you don't have enough apples, \nand why all of the gold is gone");
                Console.WriteLine("-------------------------------------------------\n");
                Console.WriteLine("Can you rate my game! Put in the umber 1 to 5, 5 being th best game ever!");
                Console.WriteLine("You have failed your family, by running out of gold. You LOSE\n\nPress Enter to Escape! And then play again to try and beat this game!!");
            }
            //Seeing if you have died of hunger and if so you showing that you have lost
            if(hunger < 0)
            {
                Console.WriteLine("\n \nAs you weakly walk out of the apples store you die of hunger");
                Console.WriteLine("-------------------------------------------------\n");
                Console.WriteLine("You have LOST");
                Console.WriteLine(" LOST!!!!");
                Console.WriteLine("Can you rate my game! Put in the umber 1 to 5, 5 being th best game ever!");
                Console.WriteLine("Press Enter to esacpe!! And then try and beat this game!!!!");
            }
            //Wining the game after you have bought enough apples
            if (foodApples > 6)
            {
                Console.WriteLine("-------------------------------------------------\n");
                Console.WriteLine("You bought enough apples and head home!! GREAT JOB YOU WIN\n\nPress Enter to Escape!");
                Console.WriteLine("Can you rate my game! Put in the umber 1 to 5, 5 being th best game ever!");
                Console.WriteLine("Nice job you did it in " + runs + " turns...think you can beat it! Play again!");

            }
            Console.ReadLine();
        }
    }
}
