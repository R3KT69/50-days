using System;

namespace c_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Day
            int dayCount = 1;

            // Random Health And Hunger
            Random hp = new Random();
            Random hg = new Random();
            int health = hp.Next(5, 10);
            int hunger = hg.Next(2,5);

            // Main Character
            MainCharacter player = new MainCharacter();
            player.health = health;
            player.hunger = hunger;
            player.invSpace1 = "";
            player.invSpace2 = "";
            player.invSpace3 = "";
            player.invSpace4 = "";
            player.invSpace5 = "";

            Console.Write("// Enter Player Name: ");
            player.Name = Console.ReadLine();

            // Weapons
            Weapons Bat = new Weapons();
            Weapons Shotgun = new Weapons();
            Weapons Pistol = new Weapons();
            Weapons Katana = new Weapons();
            Weapons Rifle = new Weapons();

            // Foods
            Foods Burger = new Foods();
            Foods Beacon = new Foods();
            Foods Corn = new Foods();
            Foods Chips = new Foods();

            // Health Condition & Hunger Condition
            string healthCondition = "";
            string hungerCondition = "";
            if (player.health <= 10)
            {
                healthCondition = "Well";
            } else if (player.health <= 5) {
                healthCondition = "Injured";
            } else if (player.health <= 3) {
                healthCondition = "Critical";
            }

            if (player.hunger <= 5)
            {
                hungerCondition = "Not hungry";
            } else if (player.hunger < 3) {
                hungerCondition = "Quite hungry";
            } else if (player.hunger == 1) {
                hungerCondition = "Starving";
            }

            
            // Data(s)
            string inventory = "\n// Your Inventory\n\nSlot 1: "+player.invSpace1+"\nSlot 2: "+player.invSpace2+"\nSlot 3: "+player.invSpace3+"\nSlot 4: "+player.invSpace4+"\nSlot 5: "+player.invSpace5+"\n";
            string map = "\n// Available Locations:\n\n1. Shopping Mall\n2. Gas Station\n3. Abandoned Park\n";
            string status = "\n// Your Status\n\nName: "+player.Name+"\nYour Health: "+player.health+"/10, Condition: "+healthCondition+". Your Hunger: "+player.hunger+"/5, Condition: "+hungerCondition+"\n";
            string Day = "\n// Current Day is "+dayCount+"/50\n";
            string inputConfirmation = "\nTo end the loop, type Next or Continue :";
            string hungerWarn = "\nYou are "+hungerCondition+"\n";
            string healthWarn = "\nYou are "+healthCondition+"\n";
            string defaultCondition = "\nYour Condition is good.\n";

            // Introduction
            Console.WriteLine("\nWelcome To 50 days.\nMade by _r3kt69\nQuit the game by closing the console window.\n");

            // Game intro
            Console.WriteLine("You are now at your home. There is a strange device on your desk.");
            Console.WriteLine("You picked up a tablet.\nYou get a list of commands, type Help for more info.\n");

            player.invSpace1 = "Tablet";
            
            mainCommands(inventory, inputConfirmation, map, status, Day, dayCount);

            // Day Starter
            dayCount++;
            player.hunger--;
            Console.WriteLine("\nDay "+dayCount+"/50 beings.\n");
            Console.WriteLine("// Daily Status");

            if (player.hunger <= 3)
            {
                Console.WriteLine(hungerWarn);
            } else if (player.health <= 5) {
                Console.WriteLine(healthWarn);
            } else {
                Console.WriteLine(defaultCondition);
            }  
        }      

        // Main input commands
        static void mainCommands(string inventory, string inputConfirmation, string map, string status,string Day, int dayCount)
        {
            // UserInput
            string userInput = "";
            bool inputDone = false;
            
            while (inputDone != true)
            {
                Console.Write("Excecute: ");
                userInput = Console.ReadLine();

                if (userInput == "Inventory")
                {
                    Console.WriteLine(inventory);
                } else if (userInput == "Help") {
                    Console.WriteLine("\nCommands are Inventory, Map, Status, Day\nType Start when you're done.\n");
                } else if (userInput == "Map") {
                    Console.WriteLine(map);
                } else if (userInput == "Status") {
                    Console.WriteLine(status);
                } else if (userInput == "Day") {
                    Console.WriteLine(Day);
                } else if (userInput == "Start") {
                    inputDone = true;
                } else {
                    Console.WriteLine("Invalid Command (Commands are case-sensitive). Valid Commands are: Inventory, Map, Status, Day, Help");
                }
            }
        }
    }
}