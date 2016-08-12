using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Fighting_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring my variables
            var ranOne = new Random();
            int talk = 0;
            int playerHealth = 10;
            int playerXP;
            int playerGold;
            int EnemyOneHeatlh = 30;
            bool dead = false;
            

            //Intro text
            Console.WriteLine("\n           Welcome to THE ULITMATE FIGHTING GAME!!");
            Console.WriteLine("\n                       INSTUCTIONS");
            Console.WriteLine("\n                   INSTERT WORDS HERE!!");
            Console.ReadKey();
            //Begening of fighting the monster
            while(playerHealth > 0 && EnemyOneHeatlh > 0 || playerHealth > 0 && talk == 4 )
            {
                //IF the monstor goes below 0 it is brought back to 0
                if(EnemyOneHeatlh <= 0)
                {
                    EnemyOneHeatlh = 0;
                }
                if (playerHealth <= 0)
                {
                    dead = true;
                    playerHealth = 0;
                }
                //Story line
                Console.WriteLine("A monster approaches you. Do you talk to it (X) or Fight is (Z)");
                //Varibale to dectect a key
                var readKey = Console.ReadKey().Key;
                //Fighting the monstor if the key is Z
                if (readKey == ConsoleKey.Z)
                {
                    //Making a random engine
                    var rolledDice = ranOne.Next(1, 8);
                    //If the random number is equal to 7 you miss, but if not then you hit the monstor and it subtracts the health
                    if (rolledDice == 7)
                    {
                        Console.WriteLine("\nYou swing and miss!");
                        //Making a random engine
                        var rolledDiceThree = ranOne.Next(1, 8);
                        //atacking player
                        playerHealth = playerHealth - rolledDiceThree;
                        Console.WriteLine(playerHealth);
                    }
                    else
                    {
                        Console.WriteLine("\nYou swing your sword with " + rolledDice + " attack!");
                        EnemyOneHeatlh = EnemyOneHeatlh - rolledDice;
                        if (EnemyOneHeatlh <= 0)
                        {
                            EnemyOneHeatlh = 0;
                        }
                        Console.WriteLine("The monstor has " + EnemyOneHeatlh + " health left");
                        //Making a random engine
                        var rolledDiceThree = ranOne.Next(1, 8);
                        //atacking player
                        playerHealth = playerHealth - rolledDiceThree;
                        Console.WriteLine(playerHealth);
                        if (playerHealth <= 0)
                        {
                            dead = true;
                        }
                    }
                }
                else if (readKey == ConsoleKey.X)
                {
                    //Making a random engine
                    var rolledDiceTwo = ranOne.Next(1, 8);
                    //If the random number is equal to 7 you miss, but if not then you hit the monstor and it subtracts the health
                    if (rolledDiceTwo <= 4)
                    {
                        Console.WriteLine("\nThe monstor looks at you funny and then attacks you");
                        Console.WriteLine("Your talking did nothing");
                        //Making a random engine
                        var rolledDiceThree = ranOne.Next(1, 8);
                        //atacking player
                        playerHealth = playerHealth - rolledDiceThree;
                        Console.WriteLine(playerHealth);
                        if (playerHealth <= 0)
                        {
                            dead = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\n The monstor is soothed by you words and lowers his defence");
                        talk++;
                        //Making a random engine
                        var rolledDiceThree = ranOne.Next(1, 8);
                        //atacking player
                        playerHealth = playerHealth - rolledDiceThree;
                        Console.WriteLine(playerHealth);
                        if (playerHealth <= 0)
                        {
                            dead = true;
                        }
                    }
                }
                //Tells you stuff after breaking the loop. Depending on the way you deffeated the monstor it will give you diffrent text.
                if (talk == 4)
                {
                    Console.WriteLine("/nThe monstor is so soothed by your words and a little annoyed that you never\n fought back leaves you");
                    Console.WriteLine("\nThe monstor leaves and you gain 4 XP and 0 Gold");
                }
                //End of program
                Console.ReadLine();

            }
        }
    }
}
