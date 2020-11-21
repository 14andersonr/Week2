using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJA3_Week_2_Challenges
{
    class Greeter //Challenge 1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey, friend!");
            GetName(); //challenge 2
            Console.WriteLine (GreetingTime()); //challenge 4
            Console.ReadLine(); //challenge 5
            Greeter Cookie = new Greeter();
            Cookie.GreetingTime(); 
            

            string GetName()
            {
                Console.WriteLine("What is your name?");
                string nameAsString = Console.ReadLine();
                Console.WriteLine($"Hello {nameAsString}!");
                Console.ReadLine();
                Goodbye();
                Console.ReadLine();
                return nameAsString;

                void Goodbye()
                {
                    Console.WriteLine($"Farewell {nameAsString}!"); //challenge 3
                }
            }

            string GreetingTime()
            {
                DateTime greeting = DateTime.Now;


                if (greeting.Hour >= 0 && greeting.Hour < 6)
                {
                    string msg = "Mornin' Sunshine!";
                    return msg; // REALLY early
                }
                else if (greeting.Hour >= 6 && greeting.Hour < 12)
                {
                    string msg = "Good morning";
                    return msg;
                }      // After 6am
                else if (greeting.Hour >= 12 && greeting.Hour < 17)
                {
                    string msg = "Good afternoon";
                    return msg;
                }    // After 12pm
                else if (greeting.Hour >= 17 && greeting.Hour < 22)
                {
                    string msg = "Good evening";
                    return msg;
                }   // After 5pm
                else if (greeting.Hour >= 22 && greeting.Hour < 24)
                {
                    string msg = "Go to bed!";
                    return msg;
                }   // After 10pm
                else
                {
                    string msg = "You exist outside of spacetime!";
                    return msg;
                }

            }


        }

        public string GetName()
        {
            Console.WriteLine("What is your name?");
            string nameAsString = Console.ReadLine();
            return nameAsString;
        }

        public int GetAge()
        {
            Console.WriteLine("How old are you?");
            string ageAsString = Console.ReadLine();

            int ageAsInt = int.Parse(ageAsString);
            return ageAsInt;
        }

        public void TellUsHowOldTheyAre(string name)
        {
            int age = GetAge();
            Console.WriteLine($"Hey {name}, you are {age} years old.");
        }

        public string GreetingTime()
        {
            DateTime greeting = DateTime.Now;

            if (greeting.Hour >= 0 && greeting.Hour < 6)
            {
                string msg = "Mornin' Sunshine!";
                return msg; // REALLY early
            }
            else if (greeting.Hour >= 6 && greeting.Hour < 12)
            {
                string msg = "Good morning";
                return msg;
            }      // After 6am
            else if (greeting.Hour >= 12 && greeting.Hour < 17)
            {
                string msg = "Good afternoon";
                return msg;
            }    // After 12pm
            else if (greeting.Hour >= 17 && greeting.Hour < 22)
            {
                string msg = "Good evening";
                return msg;
            }   // After 5pm
            else if (greeting.Hour >= 22 && greeting.Hour < 24)
            {
                string msg = "Go to bed!";
                return msg;
            }   // After 10pm
            else
            {
                string msg = "You exist outside of spacetime!";
                return msg;
            }

        }
    }
}
