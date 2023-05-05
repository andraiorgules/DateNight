using System;
using System.Collections.Generic;
namespace DateNight
{
    public class Items
    {
        // save inventory items here 
        static List<string> Inventory = new List<string>();

        //4 digit code to unlock safe
        public static string SafeCode = "2124";

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

        //player adds key to their inventory
        public static void GetKey()
        {
            Inventory.Add ("key");
            Console.WriteLine("The key has been added to your inventory.");
            Console.ReadKey();
            Console.WriteLine("Tom climbs down from the art piece.");
            Console.ReadKey();
        }

        //player doesn't get key
        public static void NoKey()
        {
            Inventory.Add("wrongpath");
        }

        //player gives Tom the key
        public static void ReturnKey()
        {
            Inventory.Add("byekey");
        }

        //player unlocks cabinet
        public static void UnlockCabinet() 
        {
            if (Inventory.Contains ("key"))
            {
                Console.WriteLine("The cabinet has a keyhole that perfectly matches the key you picked up off the ground. You open the cabinet and find a safe. " +
                    "It appears that you need a 4 digit code to unlock it.");
                string title = @"  
        ,;-------------,;
       /               /|
      |___()____()___.; |
      |               |/
       '--------------'";
                Console.WriteLine(title);
                UnlockSafe();
            }

            if (Inventory.Contains("wrongpath"))
            {
                Console.WriteLine("The cabinet has a strange keyhole. You wonder what kind of key you need to unlock it.");
            }

            if (Inventory.Contains("byekey"))
            {
                Console.WriteLine("The cabinet has a keyhole that perfectly matches the key you picked up off the ground. Sadly, you gave the key back to Tom and the cabinet cannot be opened any other way. You return to your seat just as Tom" +
                    "reenters the room.");
            }
        } 

        //player unlocks the safe and adds FishFlakes to their inventory
        public static void UnlockSafe()
        {
            string code = Console.ReadLine();
            if (code == SafeCode)
            {
                string title = @"  ____________
      ,'            '.
       \              \
        \              \
        ,;-------------,;
       /               /|
      |___()____()___.; |
      |               |/
       '--------------'";
                Console.WriteLine(title);
                if (Inventory.Contains("salmon"))
                {
                    Console.WriteLine("You open the safe and find fish flakes inside. An idea pops into your head as you tuck them away in your purse.");
                    Inventory.Add("FishFlakes");
                    Console.ReadKey();
                    Console.WriteLine("You return to your seat just as Tom reenters the room.");
                }

                else
                {
                    Console.WriteLine("You open the safe and find fish flakes inside. You wonder what those could possibbly be for and close the safe.");
                    Console.ReadKey();
                    Console.WriteLine("You return to your seat just as Tom reenters the room.");
                }
                
            }
            else
            {
                Console.WriteLine("That is incorrect. Would you like to try again?");
                Dialog("1. Yes", "magenta");
                Dialog("2. No", "magenta");
                string YesNo = Console.ReadLine();
                if (YesNo == "1")
                {
                    UnlockSafe();
                }
                else if (YesNo == "2")
                {
                    Console.WriteLine("You close the cabinet and return to your seat, wondering what could possibly be hidden in that safe.");
                    Console.WriteLine("Tom reenters the room.");
                }
                else
                {
                    Console.Clear();
                    UnlockSafe();
                }
            }
        }

        //player discovers Tom's Salmon allergy
        public static void Salmon()
        {
            Inventory.Add("salmon");
        }

        //player puts fish flakes in Tom's drink
        //player can win here
        public static void Contaminate()
        {
            if (Inventory.Contains ("FishFlakes"))
            {
                Console.WriteLine("You quickly pour the fish flakes into Tom's drink and sit back in your seat as though nothing happened.");
                Console.ReadKey();
                Console.WriteLine("Tom walks back in to the room, all cleaned up and holding another drink.");
                Dialog("I've brought you a new glass.", "red");
                Console.WriteLine("You pretend to sip the cool liquid and watch as Tom downs his.");
                Console.ReadKey();
                Console.WriteLine("Tom lets out a small cough and takes a deep breath of air.");
                Console.ReadKey();
                Console.WriteLine("You watch as Tom begins coughing violently and gasping for air.");
                Console.ReadKey();
                Dialog("What have you done?", "red");
                Console.ReadKey();
                Console.WriteLine("Tom tries to stand but falls over feebly.");
                Console.ReadKey();
                Console.WriteLine("You don't waste a single moment and book it to the door.");
                Console.ReadKey();
                Player.EndGame();
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("You walk over to Tom's jacket and begin rummaging through the pockets. You're in luck, there's a cellphone.");
                string title = @"                         .--.
                          |  |
                          |  |
                          |  |
                          |  |
         _.-----------._  |  |
      .-'      __       `-.  |
    .'       .'  `.        `.|
   ;         :    :          ;
   |         `.__.'          |
   |   ___                   |
   |  (_M_) M O T O R A L A  |
   | .---------------------. |
   | |                     | |
   | |                     | |
   | |                     | |
   | |                     | |
   | |                     | |
   | |                     | |
   | |                     | |
   | `---------------------' |
   |                         |
   |                __       |
   |  ________  .-~~__~~-.   |
   | |___C___/ /  .'  `.  \  |
   |  ______  ;   : OK :   ; |
   | |__A___| |  _`.__.'_  | |
   |  _______ ; \< |  | >/ ; |
   | [_=";
                Console.WriteLine(title);
                Apartment.DialPhone();
           }
        }

        //print items player collected
        public static void PrintInventory()
        {
            foreach (string item in Inventory)
            {
                Console.WriteLine("You have collected " + item);
            }
        }
           
    }
}



