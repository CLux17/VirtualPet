﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    class Menu
    {

        string petName = "";
        string petSpecies = "";
        Pet firstPet;              

        public bool ShowMenu()
        {
            Console.WriteLine("Type 1 to create a pet.");
            Console.WriteLine("Type 2 to show pet info.");
            Console.WriteLine("Type 3 to show pet status");
            Console.WriteLine("Type 4 to exit\n");
            
            string menuInput = Console.ReadLine();

            if (menuInput == "1")
            {
                
                Console.WriteLine("\nEnter your pet name:");
                petName = Console.ReadLine();

                Console.WriteLine("");
                Console.WriteLine("Enter your pet species:");
                petSpecies = Console.ReadLine();

                firstPet = new Pet(petName, petSpecies, 0, 0, 100);

                Console.WriteLine("");
                Console.WriteLine(firstPet.Name + " was added to the shelter!\n");

                return true;

            }
            else if (menuInput == "2" && firstPet != null)
            {
                Console.WriteLine("\nYour pet name is " + firstPet.Name + " and your pet is a " + firstPet.Species + ".\n");

                return true;

            }
            else if (menuInput == "3" && firstPet != null)
            {
                Console.WriteLine("\n" + firstPet.Name + "'s hunger is " + firstPet.Hunger);
                Console.WriteLine(firstPet.Name + "'s boredom is " + firstPet.Boredom);
                Console.WriteLine(firstPet.Name + "'s health is " + firstPet.Health + "\n");

                return true;
            }
            else if (menuInput == "4")
            {
                return false;
            }

            else return true;

           


        }
    }
}
