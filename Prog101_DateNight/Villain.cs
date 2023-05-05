using System;
namespace DateNight
{
    public class Villain
    {
        public static string VillainName = "Tom";

        static int MaxAnger = 2;
        static int AngerLevel = 0;
        
        //dialog colors
        static void Dialog(string message, string color)
        {
            if (color == "red")
            { Console.ForegroundColor = ConsoleColor.Red; }
            if (color == "magenta")
            { Console.ForegroundColor = ConsoleColor.Magenta; }
            if (color == "blue")
            { Console.ForegroundColor = ConsoleColor.Cyan; }
            Console.WriteLine(message);
            Console.ResetColor();
        }

        //Tom takes the player on a walk
        public static void GoWalk()
        {
            Dialog("I hope I haven't kept you waiting too long", "red");
            Console.ReadKey();
            Dialog("Not at all...", "magenta");
            Console.ReadKey();
            string title = @"  _______
 /  12   \
|    |    |
|9   |   3|
|     \   |
|         |
 \___6___/";
            Console.WriteLine(title);
            Dialog("My goodness, look at the time. The restaurant is closing. My apartment isn't far from here. Would you like to continue our date there?", "red");
            Console.ReadKey();
            Console.WriteLine("Choose your response");
            Dialog("1. It's getting pretty late. I should go home.", "magenta");
            Dialog("2. Lead the way.", "magenta");
            string choice3 = Console.ReadLine();
            if (choice3 == "1")
            {
                Dialog("Nonsense! The night is still young! Follow me.", "red");
            }
            else if (choice3 == "2")
            {
                Dialog("Then follow me.", "red");
            }
            else
            {
                Console.Clear();
                GoWalk();
            }

        }

        //Tom urgers the player to get cotton candy
        public static void GetCottonCandy()
        {
            Dialog("1. Red, please.", "magenta");
            Dialog("2. Green, please.", "magenta");
            Dialog("3. No, thank you.", "magenta");
            string choice4 = Console.ReadLine();
            if (choice4 == "1")
            {
                Dialog("How did you know that was my favorite color?", "red");
            }

            else if (choice4 == "2")
            {
                Console.WriteLine("Tom's easy-going smile faltered.");
                AngerLevel++; // anger level +1
                Dialog("What an interesting choice.", "red");
            }

            else if (choice4 == "3")
            {
                Dialog("Nonsense! There is no reason not to take some free cotton candy. Why don't you pick again?", "red");
                GetCottonCandy();
            }
            else
            {
                Console.Clear();
                Dialog("Good Evening. Would you like some cotton candy? I need to close up shop, but I still have TWO flavors left: Red and Green. ", "blue");
                Console.ReadKey();
                GetCottonCandy();
            }
        }

        //Tom receives a key from the player
        public static void GiveKey()
        {
            Console.WriteLine("Tom climbs down from the art piece.");
            Dialog("What are you doing with this? Give it back immediately.", "red");
            Console.WriteLine("Tom's easy-going smile has faded away.");
            if (AngerLevel < MaxAnger)
            {
                AngerLevel++; //anger level +1
            }
            Console.ReadKey();
            Items.ReturnKey();
        }

        //Tom invites the player to his apartment
        //player can lose here
        public static void AtDoor() 
        {
            string title = @"            __________
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
            Console.WriteLine("You finally reach the door to " + VillainName + "'s apartment."); 
            Dialog("All that walking has made me thirsty. Would you like a drink?", "red");
            Dialog("1. I'd like to go home", "magenta");
            Dialog("2. Yes, please.", "magenta");
            string choice6 = Console.ReadLine();
            if (choice6 == "1")
            {
                if (AngerLevel >= 2 )    
                {
                    Dialog("I don't really think you have a choice.", "red");
                    Console.ReadKey();
                    Console.WriteLine("Game Over. What would you like to do next?");
                    Dialog("1. End.", "magenta");
                    Dialog("2. Return to Checkpoint.", "magenta");
                    string choice7 = Console.ReadLine();
                    if (choice7 == "1")
                    {
                        Player.EndGame();
                        Environment.Exit(0);
                    }
                    else if (choice7 == "2")
                    {
                        Console.Clear();
                        AtDoor();
                    }
                }
                else
                {
                    Dialog("Please, it's no trouble. Come rest inside before you go home.", "red");
                }
            }
            else if (choice6 == "2")
            {
                Dialog("Please allow me to hold the door for you.", "red");
            }
            else
            {
                Console.Clear();
                AtDoor();
            }

        }

    }
        
    
}
