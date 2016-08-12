using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Add_Function
{
    class Program
    {
        //Declaring public varibales
        //Keeps track wether the person has pressed escape to end the program!
        static public bool alive = true;
        //User's first number
        static public int a;
        //User's second number
        static public int b;
        //Used to store the answer after the caculations have finished
        static public int c;
        //User's number put in if thery chose to round
        static public double d;
        //Used to store the answer of the rounded number after the cacylations have finished
        static public double e;
        //First funcion: Add
        static public int Add(int a, int b)
        {
            //Directing the user to input there first number
            Console.WriteLine("Enter value of 'a':");
            a = Convert.ToInt32(Console.ReadLine());
            //Directing the user to input there second number
            Console.WriteLine("Enter value of 'b':");
            b = Convert.ToInt32(Console.ReadLine());
            int answer = a + b;
            return answer;
        }
        //Second Function subtraction
        static public int Subtract(int a, int b)
        {
            //Directing the user to input there first number
            Console.WriteLine("Enter value of 'a':");
            a = Convert.ToInt32(Console.ReadLine());
            //Directing the user to input there second number
            Console.WriteLine("Enter value of 'b':");
            b = Convert.ToInt32(Console.ReadLine());
            int answer = a - b;
            return answer;
        }
        //Third function multlipying
        static public int Multlipy(int a, int b)
        {
            //Directing the user to input there first number
            Console.WriteLine("Enter value of 'a':");
            a = Convert.ToInt32(Console.ReadLine());
            //Directing the user to input there second number
            Console.WriteLine("Enter value of 'b':");
            b = Convert.ToInt32(Console.ReadLine());
            //Doing the cacualtion
            int answer = a * b;
            //Storing the caculation.
            return answer;
        }
        //Fourth function Divideing
        static public int Divide(int a, int b)
        {
            //Directing the user to input there first number
            Console.WriteLine("Enter value of 'a':");
            a = Convert.ToInt32(Console.ReadLine());
            //Directing the user to input there second number
            Console.WriteLine("Enter value of 'b':");
            b = Convert.ToInt32(Console.ReadLine());
            int answer = a / b;
            return answer;
        }
        //Fifth function rounding
        static public double Round(double d)
        {
            //Directing the user to input the number they wish to round.
            Console.WriteLine("Enter value of your decmial that you wish to round!:");
            d = Convert.ToDouble(Console.ReadLine());
            //Rounding the number
            double answer = Math.Round(d);
            return answer;
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("---------------WELCOME TO THE GREAT AND AWESOME CACULATOR 101-------------------");
            Console.WriteLine("--------------------------------------------------------------------------------");
            while (alive)
            {

                Console.WriteLine("Press ESACPE to exit the program");
                Console.WriteLine("--------------------------------------------------------------------------------");
                Console.WriteLine("Enter 1 for adding 2 for subtracting\n3 for multplying 4 for divideing\n5 for rounding");
                Console.WriteLine("USE YOUR NUMBERS ON THE TOP OF YOU KEYBOARD FOR BETTER PERFORMANCE!");
                var keyReading = Console.ReadKey().Key;
                if (keyReading == ConsoleKey.Escape)
                {
                    Console.WriteLine("Are you sure you want to leave? \nPRESS Y TO LEAVE! PRESS N TO STAY");
                    bool incorrectKeyPressed = true;
                    while (incorrectKeyPressed)
                    {
                        var readKeyToExit = Console.ReadKey().Key;
                        if (readKeyToExit == ConsoleKey.N)
                        {
                            alive = true;
                            incorrectKeyPressed = false;
                            
                        }
                        else if (readKeyToExit == ConsoleKey.Y)
                        {
                            alive = false;
                            incorrectKeyPressed = false;
                        }
                        else
                        {
                            Console.WriteLine("You pressed a weird key!");
                            incorrectKeyPressed = true;
                        }
                    }
                }
                if (keyReading == ConsoleKey.D1 || keyReading == ConsoleKey.NumPad1)
                {
                    c = Add(a, b);
                    Console.WriteLine("a + b = " + c);
                }
                if (keyReading == ConsoleKey.D2 || keyReading == ConsoleKey.NumPad2)
                {
                    c = Subtract(a, b);
                    Console.WriteLine("a - b = " + c);
                }
                if (keyReading == ConsoleKey.D3|| keyReading == ConsoleKey.NumPad3)
                {
                    c = Multlipy(a, b);
                    Console.WriteLine("a * b = " + c);
                }
                if (keyReading == ConsoleKey.D4 || keyReading == ConsoleKey.NumPad4)
                {
                    c = Divide(a, b);
                    Console.WriteLine("a / b = " + c);
                }
                if (keyReading == ConsoleKey.D5 || keyReading == ConsoleKey.NumPad5)
                {
                    e = Round(d);
                    Console.WriteLine("Your new number is " + e);
                }
            }
            while (alive)
            {

                Console.WriteLine("Press ESACPE to exit the program");
                Console.WriteLine("--------------------------------------------------------------------------------");
                Console.WriteLine("Enter 1 for adding 2 for subtracting\n3 for multplying 4 for divideing\n5 for rounding");
                Console.WriteLine("USE YOUR NUMBERS ON THE TOP OF YOU KEYBOARD FOR BETTER PERFORMANCE!");
                var keyReading = Console.ReadKey().Key;
                if (keyReading == ConsoleKey.Escape)
                {
                    Console.WriteLine("Are you sure you want to leave? \nPRESS Y TO LEAVE! PRESS N TO STAY");
                    bool incorrectKeyPressed = true;
                    while (incorrectKeyPressed)
                    {
                        var readKeyToExit = Console.ReadKey().Key;
                        if (readKeyToExit == ConsoleKey.N)
                        {
                            alive = true;
                            incorrectKeyPressed = false;

                        }
                        else if (readKeyToExit == ConsoleKey.Y)
                        {
                            alive = false;
                            incorrectKeyPressed = false;
                        }
                        else
                        {
                            Console.WriteLine("You pressed a weird key!");
                            incorrectKeyPressed = true;
                        }
                    }
                }
                if (keyReading == ConsoleKey.D1 || keyReading == ConsoleKey.NumPad1)
                {
                    c = Add(a, b);
                    Console.WriteLine("a + b = " + c);
                }
                if (keyReading == ConsoleKey.D2 || keyReading == ConsoleKey.NumPad2)
                {
                    c = Subtract(a, b);
                    Console.WriteLine("a - b = " + c);
                }
                if (keyReading == ConsoleKey.D3 || keyReading == ConsoleKey.NumPad3)
                {
                    c = Multlipy(a, b);
                    Console.WriteLine("a * b = " + c);
                }
                if (keyReading == ConsoleKey.D4 || keyReading == ConsoleKey.NumPad4)
                {
                    c = Divide(a, b);
                    Console.WriteLine("a / b = " + c);
                }
                if (keyReading == ConsoleKey.D5 || keyReading == ConsoleKey.NumPad5)
                {
                    e = Round(d);
                    Console.WriteLine("Your new number is " + e);
                }
            }


        }
    }
}