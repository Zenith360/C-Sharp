using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Typeing_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan last = TimeSpan.MaxValue;
            /*
            User will type letters as they appear and red will indatice that they failed to hit the right key. Now how to start
            ......
            */
            Console.WriteLine("Wellcome to this typeing thing... Ok lets start :)");   
            Console.WriteLine("Remeber don't put in commas");
            //This is here because I dont know how to convert a Readkey to upper case soo I hace them do it
            Console.WriteLine("PUT CAPS ON RIGHT NOW please");
            Thread.Sleep(1000);
            Console.WriteLine("3");
            Thread.Sleep(1000);
            Console.WriteLine("2");
            Thread.Sleep(1000);
            Console.WriteLine("1");
            Thread.Sleep(1000);
            Console.WriteLine("Game Started");
            bool play = true;
            while(play)
            {

                var date_1 = DateTime.Now;
                int mess_up = 0;
                //This is the thing you will be typeing as of now I didn't put in commas
                string words = "For to us a child is born to us a son is given and the government will be on his shoulders and he will be called Wonderful Counselor Mighty God Everlasting Father Prince of Peace";
                string upper_words = words.ToUpper();
                for (int i = 0; i < upper_words.Length; ++i)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    //Grabs their input
                    char user_input = Console.ReadKey(true).KeyChar;
                    //puts the Ith one of words into a char
                    char new_word = Convert.ToChar(upper_words[i]);
                    //test if they put in the right thing
                    if(user_input != new_word)
                    {
                        //This is the basic way to tell the user the messed up.
                        Console.BackgroundColor = ConsoleColor.Red;
                        //Puts what they were suppsoed to put in red
                        Console.Write(upper_words[i]);
                        ++mess_up;
                    }
                    else
                    {
                        //Else keep it normal
                        Console.BackgroundColor = ConsoleColor.Black;
                        //Puts what they were suppsoed to put in red
                        Console.Write(upper_words[i]);
                    }
                }
                var date_2 = DateTime.Now;
                TimeSpan time = date_2 - date_1;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("\nGood Job!! OK now for the results");
                Console.WriteLine("You missed " + mess_up + " amount of times, and it took you " + time + " amount of time");
                if (last != TimeSpan.MaxValue)
                {
                    Console.WriteLine(last - time);
                }
                last = time;
                if (mess_up == 0)
                {
                    Console.WriteLine("WOW, perfect score nice!");
                    Console.WriteLine("Do you wanna quit? (Y OR N)");
                    if (Console.ReadKey().Key == ConsoleKey.Y)
                    {
                        Console.WriteLine("Thanks for playing bye!");
                        play = false;

                    }
                    else
                    {
                        Console.WriteLine("Lets keep playing!");
                    }
                }
                
                else if(mess_up < 10)
                {
                    Console.WriteLine("Hey thats pretty good! You got this down!");
                    Console.WriteLine("Do you wanna quit? (Y OR N)");
                    if(Console.ReadKey().Key == ConsoleKey.Y)
                    {
                        Console.WriteLine("Thanks for playing bye!");
                        play = false;

                    }
                    else
                    {
                        Console.WriteLine("Lets keep playing!");
                    }
                }
                else if(mess_up < 20)
                {
                    Console.WriteLine("Maybe a few more trys, but thats still really good!");
                }
                else
                {
                    Console.WriteLine("Keep Trying!");
                }
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
