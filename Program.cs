using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Activity_2
{
    class Program
    {



        static void Main(string[] args)
        {
            Console.WriteLine("What is your name ? ");
            string a = (Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Would you like to play a game ? Type yes or no.");
            string b = Console.ReadLine();


            if (b == "yes")
            {
                Console.WriteLine("Excellent! You are walking across a field and you encounter a fire breathing dragon!");
                Console.WriteLine(" What would you do? face the beast or run away");
                string c = Console.ReadLine();

                if (c == "face the beast")
                {
                    Console.WriteLine("You approached the Dragon.");
                    Console.WriteLine("the number of heads ");
                    Console.WriteLine(" 1 or 2 or 3");
                    String d = Console.ReadLine();
                    do
                    {                  
                        switch (d)
                        {
                            case "1":
                            case "2":
                            case "3":


                                Console.WriteLine(d + "headed dragon enters.");
                                break;
                            default:
                                Console.WriteLine("Invalid selection. Please select 1, 2, or 3.");
                                break;

                        }
                    } while (d != "1" && d != "2" && d != "3");

                    string e = "";

                    Console.WriteLine("Choose your weapon \n\n Enter Slingshot or Sword or Bow and Arrow");
                    e = Console.ReadLine();
                    switch (e)

                    {
                        case "slingshot":
                        case "sword":
                        case "bow and arrow":

                            Console.WriteLine("Armed with your" + e + "you approach the" + d + "dragon!");
                            break;
                        default:
                            Console.WriteLine("Invalid selection. Please select slingshot, sword, or bow and arrow.");
                            break;
                    }
                    while (e != "slingshot" && e != "sword" && e != "bow and arrow") ;


                    Console.WriteLine("Enter the dragon's eye colour");
                    Console.WriteLine("enter Red or Blue");

                    String f = Console.ReadLine();

                    if (f == "Red")
                    {
                        Console.WriteLine("Oh thank goodness! \n\n Red eyed dragon are friendly \n\n You pet it and become friends.");

                    }


                    Console.WriteLine("You can name the dragon, enter the name: ");
                    string g = Console.ReadLine();


                    Console.WriteLine("Aisha and" + g + "lived happily ever after");



                }


            }
            else
            {
                Console.WriteLine("Thank You");

            }


            // Console.WriteLine("You approached the Dragon.");
            //Console.WriteLine("");

            //            Console.WriteLine("No one has ever faced a 3 headed dragon before !");











        }
    }
}
