using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ClickPlayFalse = true;
            Console.WriteLine("Welcome to Black Jack! \nClick I for intstructions or enter to play!");
            while(ClickPlayFalse)
            {
                var start_or_intro = Console.ReadKey().Key;
                if(start_or_intro == ConsoleKey.I)
                {
                    ClickPlayFalse = true;
                    Console.WriteLine("How to Play Black Jack!");
                    Console.WriteLine("The goal is to make both of your cards number combined to equal 21 or really close to 21.");
                    Console.WriteLine("You bet an amount of money and see if you beat the house. They way the house works is that it does the same as you but must get a second card if there total is 16");
                    Console.WriteLine("If you second card goes over 21 you lose and the House gets all of the money");
                    Console.WriteLine("If you think that your total is too low than you can get another card");
                }
                else if(start_or_intro == ConsoleKey.Enter)
                {
                    Console.WriteLine("Get ready to Play!!");
                    ClickPlayFalse = false;
                }
                else
                {
                    ClickPlayFalse = true;
                    Console.WriteLine("You clicked a wrong key please try again. Remeber I for instruction to play and enter to play!");
                }
            }
            Console.WriteLine("You Have been given 100 chips");
            int chips = 100;
            bool chipsNotEqualZero = true;
            while(chipsNotEqualZero)
            {
                bool betting = true;
                while (betting)
                {
                    Console.WriteLine("How much do you bet??");
                    int bet = Convert.ToInt32(Console.ReadLine());
                    if (bet >= chips)
                    {
                        Console.WriteLine("You can't bet that much you. You dont have enough!");
                    }
                    else
                    {
                        chips -= bet;
                        betting = false;
                    }
                }
                Console.WriteLine("Chips: " + chips);
                var rand = new Random();
                int cardOne = rand.Next(0, 14);
                Console.WriteLine("You draw a card and it equals to " + cardOne);
                int cardTotal;
                bool drawingCards = true;
                while (drawingCards)
                {
                    Console.WriteLine("Do you draw another card? Y/N");
                    var new_Card = Console.ReadKey().Key;
                    int cardTwo;
                    if (new_Card == ConsoleKey.Y)
                    {
                        cardTwo = rand.Next(0, 14);
                        Console.WriteLine("You draw another card and it equals to " + cardTwo);
                        cardTotal = cardOne + cardTwo;
                        Console.WriteLine("Total: " + cardTotal);
                    }
                    else if (new_Card == ConsoleKey.N)
                    {
                        cardTwo = 0;
                        Console.WriteLine("And you going with your one card...Good chocie or terrible decsion!!!");
                        cardTotal = cardOne + cardTwo;
                        Console.WriteLine("Total: " + cardTotal);
                        drawingCards = false;
                    }
                    else
                    {
                        Console.WriteLine("Nice going, you hit a wrong key and I am to lazy to put in another while loop so your starting this round over");
                    }
                }
            }
                

        }
    }
}

