using System;
namespace DateNight
{
    public class Player
    {
        //get player's name 
        public static string Name { get; set; }

        //ask player for a name, and save it
        public static void NameCharacter()
        {
            Console.WriteLine("What is your name?");
            Name = Console.ReadLine();
            Name = Name.ToUpper();

            Console.WriteLine("Good Evening, " + Name);
            Console.WriteLine("Have fun on your date.");
        }

        //dialog colors
        static void Dialog(string message, string color)
        {
            if (color == "red")
            { Console.ForegroundColor = ConsoleColor.Red; }
            if (color == "magenta")
            { Console.ForegroundColor = ConsoleColor.Magenta; }
            if (color == "blue")
            { Console.ForegroundColor = ConsoleColor.Cyan; }
            if (color == "green")
            { Console.ForegroundColor = ConsoleColor.Green; }
            Console.WriteLine(message);
            Console.ResetColor();
        }

        //Player introduction to Tom
        public static void MeetTom()
        {
            string title = @"               __                        @@;,
              (  ;          ?           :  );
             _| |_  |  |   ||  |  |     _| |_
            |  \  \  \/    ||   \/ ___ /  /  |
          __|   |\ __||____||___||______/|   |
          |||   | |_______    _________| |   |||
          |||   |____     |   |      ____|   |||      
          \ \______  )    |   |     /  ______/ /
           ||    | | |    |   |    /___|     ||  
           ||    | | |_  /| | |\   _| ||     ||
           ||    | \__, / | | |  \<__/ |     ||
 "; 
            Console.WriteLine(title);
            Console.WriteLine("You walk into the restaurant and see a handsome man waving you over.");
            Console.ReadKey();
            Dialog("Hello, My name is Tom. It's a pleasure to meet you, " + Name, "red"); 
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Choose your response:");
            Dialog("1. Likewise.", "magenta");
            Dialog("2. I don't want to meet you.", "magenta");
            string choice1 = Console.ReadLine();
            if (choice1 == "1")
            {
                Dialog("Shall we sit?", "red");
            }
            else if (choice1 == "2")
            {
                Dialog("What a kidder! Shall we sit?", "red");
            }
            else
            {
                Console.Clear();
                MeetTom();
            }
        }

        //player chooses meal
        public static void ChooseMeal()
        {
            Dialog("Thank you for joining me on this splendid evening.", "red");
            Console.ReadKey();
            Dialog("I can't wait to get to know you. But first, let's order our food.", "red");
            Console.ReadKey();
            string title = @"     ______ ______
    /      |      \
   / ~~ ~~ | ~~ ~  \
  / ~ ~ ~~ | ~~~ ~~ \     
 /________ | ________\";
            Console.WriteLine(title);
            Dialog("Would you like Steak or Salmon?", "red");
            Console.ReadKey();
            Console.WriteLine("Choose your response");
            Dialog("1. Steak", "magenta");
            Dialog("2. Salmon", "magenta");
            string choice2 = Console.ReadLine();
            if (choice2 == "1")
            {
                Dialog("A fine choice.", "red");
            }
            else if (choice2 == "2")
            {
                Dialog("I'm severly allergic to seafood, would you mind ordering the steak instead?", "red");
                Dialog("Of course.", "magenta");
                Items.Salmon();
            }
            else
            {
                Console.Clear();
                ChooseMeal();
            }
        }

        //the player receives a drink from Tom
        public static void Drink()
        {
            string title = @"           ___,
          '._.'\
       _____/'-.\
      |    / |
      |~~~/~~|
      \ ()   /
       '.__.'
         ||
        _||_
       `----`";
            Console.WriteLine(title);
            Dialog("I've brought your drink.", "red");
            Console.WriteLine("What will you do?");
            Dialog("1. Drink it.", "magenta");
            Dialog("2. Accidentally knock it over.", "magenta");
            string choice9 = Console.ReadLine();
            if (choice9 == "1")
            {
                Console.WriteLine("You quickly drink the cool liquid.");
                Console.ReadKey();
                Dialog("It was so wonderful meeting you.", "red");
                Console.ReadKey();
                Console.WriteLine("You start feeling dizzy and your vision begins to blur.");
                Console.ReadKey();
                Console.WriteLine("You try to stand, but feebly fall back down.");
                Console.ReadKey();
                Console.WriteLine("Tom's devlish grin is the last thing you see before everything fades to black...");
                Console.ReadKey();
                Console.WriteLine("Game Over");
                Console.WriteLine("What would you like to do next?");
                Dialog("1. End", "magenta");
                Dialog("2. Return to Checkpoint", "magenta");
                string choice10 = Console.ReadLine();
                if (choice10 == "1")
                {
                    EndGame();
                    Environment.Exit(0);
                }
                else if (choice10 == "2")
                {
                    Drink();
                }
                else
                {
                    Console.Clear();
                    Drink();
                }
            }
            else if (choice9 == "2")
            {
                Console.WriteLine("You miscalculate how far away the glass is and bump into it with your arm.");
                Console.WriteLine("The drink falls on its side and spills all over Tom.");
                Console.ReadKey();
                Dialog("Watch it!", "red");
                Console.ReadKey();
                Dialog("I'm going to the bathroom to clean up. Don't move.", "red");
                Console.ReadKey();
                Items.Contaminate();
            }
            else
            {
                Console.Clear();
                Drink();
            }
        }

        //player is saved by the police
        //player completes the game here
        public static void Escape() 
        { 
            Console.WriteLine("Tom steps back into the room, all cleaned up and holding another drink.");
            Dialog("I've brought you a new glass.", "red");
            Console.ReadKey();
            Console.WriteLine("You slowly take a sip as you watch Tom down his.");
            Console.ReadKey();
            Dialog("Don't be shy. Have some more.", "red");
            Console.ReadKey();
            Console.WriteLine("You take the tiniest of sips.");
            Console.ReadKey();
            Dialog("What are you waiting for?! Just drink it!", "red");
            Console.ReadKey();
            string title = @" __________
           |  __  __  |
           | |  ||  | |
           | |  ||  | |
           | |__||__| |
           |  __  __()|
           | |  ||  | |
           | |  ||  | |
           | |  ||  | |
           | |  ||  | |
           | |__||__| |
           |__________|";
            Console.WriteLine(title);
            Console.WriteLine("A knock is heard at the door.");
            Console.ReadKey();
            Dialog("Go away! We are busy!", "red");
            Console.ReadKey();
            Dialog("It's the police, open up. We need to ask you a few questions...", "green");
            Console.ReadKey();
            Console.WriteLine("...");
            Console.ReadKey();
            Console.WriteLine("After a bit of questioning, you are sent home.");
            Dialog("Safe at last.", "magenta");
        }

        public static void EndGame()
        {
            //title art
            string title = @"
 ██████╗  █████╗ ███╗   ███╗███████╗    ███████╗███╗   ██╗██████╗ 
██╔════╝ ██╔══██╗████╗ ████║██╔════╝    ██╔════╝████╗  ██║██╔══██╗
██║  ███╗███████║██╔████╔██║█████╗      █████╗  ██╔██╗ ██║██║  ██║
██║   ██║██╔══██║██║╚██╔╝██║██╔══╝      ██╔══╝  ██║╚██╗██║██║  ██║
╚██████╔╝██║  ██║██║ ╚═╝ ██║███████╗    ███████╗██║ ╚████║██████╔╝
 ╚═════╝ ╚═╝  ╚═╝╚═╝     ╚═╝╚══════╝    ╚══════╝╚═╝  ╚═══╝╚═════╝ 
                                                                  
";
            Console.WriteLine(title);
            Console.Read();
            Console.WriteLine("Thank you for playing " + Name);
            Items.PrintInventory();
            Console.WriteLine("Press Enter To Continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}

