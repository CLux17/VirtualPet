﻿using System;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Virtual Pet!");
            Console.WriteLine("Type in start to begin game. At any time, type exit to end game.");
            bool gameIsRunning = false;                                         //program is off.
            string mainMenu = Console.ReadLine();
            if(mainMenu == "start")
            {
                gameIsRunning = true;
            }


            string gameInput;
            while(gameIsRunning)
            {
                Console.WriteLine("What kind of pet do you want to create?");
                Console.WriteLine("For cat type \"cat\".");
                gameInput = Console.ReadLine();
                            
                if (gameInput == "exit")
                    gameIsRunning = false;
            }
        }
    }
}
