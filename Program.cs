using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haunted_house
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Haunted House!");
            Console.WriteLine("You find yourself standing in front of a dark, eerie house. Do you dare to enter?");
            Console.WriteLine("Type 'yes' to enter or 'no' to run away.");

            string choice = Console.ReadLine().ToLower();

            if (choice == "yes")
            {
                EnterHouse();
            }
            else if (choice == "no")
            {
                Console.WriteLine("You chose to run away. Maybe next time you’ll be brave enough!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Game over.");
            }
        }

        static void EnterHouse()
        {
            Console.WriteLine("You enter the haunted house. It's dark and silent.");
            Console.WriteLine("Suddenly, you hear a whisper. 'Who dares enter my domain?'");
            Console.WriteLine("Do you explore the house or run away? (explore/run)");

            string choice = Console.ReadLine().ToLower();

            if (choice == "explore")
            {
                ExploreHouse();
            }
            else if (choice == "run")
            {
                Console.WriteLine("You chose to run away. The ghost lets out a chilling laugh as you escape.");
            }
            else
            {
                Console.WriteLine("Invalid choice. Game over.");
            }
        }

        static void ExploreHouse()
        {
            Console.WriteLine("You decide to explore the house. As you walk through the hallway, you feel a cold breeze.");
            Console.WriteLine("You see two doors. Do you enter the left door or the right door? (left/right)");

            string choice = Console.ReadLine().ToLower();

            if (choice == "left")
            {
                Console.WriteLine("You enter the left door and find a room filled with ancient books. You start reading and get lost in the stories. The ghost approves.");
            }
            else if (choice == "right")
            {
                Console.WriteLine("You enter the right door and fall into a trap. The ghost captures you. Game over.");
            }
            else
            {
                Console.WriteLine("Invalid choice. Game over.");
            }
        }
    }
}