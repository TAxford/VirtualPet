using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            int playersChoice;


            VirtualPet puppy = new VirtualPet(false, true, true, false);

            Console.WriteLine("Hello I am Twinkletoe the puppy, it is nice to meet you. Lets play.");

            do
            {

                Console.WriteLine("What would you like to do?");
                Console.WriteLine("To feed me, type 1");
                Console.WriteLine("To play with me, type 2");
                Console.WriteLine("To put me to bed, type 3");
                Console.WriteLine("To clean me, type 4");
                Console.WriteLine("To check my stats, type 5");

                playersChoice = int.Parse(Console.ReadLine());

                switch (playersChoice)
                {
                    case 1:
                        Console.WriteLine("Thank you for feeding me");
                        puppy.Hungry();
                        break;

                    case 2:
                        Console.WriteLine("You threw that ball far");
                        puppy.Tired();
                        break;

                    case 3:
                        Console.WriteLine("ZZZZZZ bark ZZZZZ");
                        puppy.Tired();
                        break;

                    case 4:
                        Console.WriteLine("Splash Splash I am taking a bath");
                        puppy.Dirty();
                        break;

                    case 5:
                        Console.WriteLine(puppy);
                        break;


                }
                Console.WriteLine("");

            }
            while (playersChoice != 5);


























































        }
    }
}

























































