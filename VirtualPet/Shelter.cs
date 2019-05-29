﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    class Shelter
    {
        string petName = "";
        string petSpecies = "";
        string inputPetType = "";
        string petType = "";

        public string Name;

        public Shelter(string name)
        {
            Name = name;
        }

        public List <Pet> listOfPets = new List <Pet>();

        public void CreateShelter()
        {
            Shelter shelter = new Shelter("Your Shelter");
        }

        public void CreatePet()
        {
            Pet firstPet;
            Robotic firstRobotPet;

            Console.WriteLine("What Type of pet is it?\n" + 
                "Type 1 for Organic\n" + 
                "Type 2 for Robotic");

            inputPetType = Console.ReadLine();

            if (inputPetType == "2")
            {
                petType = "Robot";
                Console.WriteLine("\nEnter your pet name:");
                petName = Console.ReadLine();

                Console.WriteLine("\nEnter your pet species:");
                petSpecies = Console.ReadLine();


                firstRobotPet = new Robotic(petName, petSpecies);
                AddToShelterList(firstRobotPet);


                Console.Clear();
                Console.WriteLine(firstRobotPet.Name + " the " + this.petType + " " + this.petSpecies + ", was added to the shelter!\n");
            }

            else 
            {
            Console.WriteLine("\nEnter your pet name:");
            petName = Console.ReadLine();

            Console.WriteLine("\nEnter your pet species:");
            petSpecies = Console.ReadLine();


            firstPet = new Pet(petName, petSpecies);
            AddToShelterList(firstPet);

            
            Console.Clear();
            Console.WriteLine(firstPet.Name + " was added to the shelter!\n");
            }
        }


        public void AddToShelterList(Pet firstPet)
        {
            listOfPets.Add(firstPet);

        }

        public void RemoveFromShelterList(Pet selectedPet)
        {
            Console.WriteLine(selectedPet.Name + " has been adopted");
            listOfPets.Remove(selectedPet);
        }
        
        public void ViewPetList()
        {
            Console.WriteLine("Here are the pets in your shelter:\n");
            foreach (Pet element in listOfPets)
            {
                Console.WriteLine("Pet Name: " + element.Name);
                Console.WriteLine("Pet Species: " + element.Species);
                Console.WriteLine("Pet Type: " + element.PetType);
                Console.WriteLine("");
            }
        }

        public void ViewPetStatus()
        {
            Console.WriteLine("Here are your pets' status:");
            foreach(Pet element in listOfPets)
            {
                Console.WriteLine("");
                Console.WriteLine("Pet name:" + element.Name  );
                Console.WriteLine("Hunger:" + element.Hunger);
                Console.WriteLine("Boredom:" + element.Boredom);
                Console.WriteLine("Health:" + element.Health);
                Console.WriteLine("");
            }
        }
        
        public void IndividualPetList()
        {
            int i =0;

            foreach(Pet element in listOfPets)
            {
               i = i + 1;
                Console.WriteLine(i+ " "+element.Name );
            }
            
        }
        
    }

}
