using System;
namespace DateNight
{
    public class Apartment
    {
        //phone number for DialPhone
        public static string PhoneNumber = "911";

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

        //player uses the phone
        public static void DialPhone()
        {
            Console.WriteLine("What number will you dial?");
            string Number = Console.ReadLine();
            if (Number == PhoneNumber)
            {
                Console.WriteLine("The line rings as you wait for the police to pick up. You quickly whisper your location and beg them to hurry.");
                Console.ReadKey();
                Console.WriteLine("You put the phone back where you found it and quickly move away from the jacket.");
            }
            else
            {
                Console.WriteLine("That number is not available. Wouldn't you prefer to call the police?");
                Dialog("1. Yes", "magenta");
                Dialog("2. No", "magenta");
                string NoYes = Console.ReadLine();
                if (NoYes == "1")
                {
                    DialPhone();
                }
                else if (NoYes == "2")
                {
                    Console.WriteLine("Listen to your gut and call the police.");
                    DialPhone();
                }
            }
        }

        //player searches for the safe
        public static void ExploreApartment()
        {
            Dialog("1. Stay seated.", "magenta");
            Dialog("2. Explore the living room.", "magenta");
            string choice8 = Console.ReadLine();
            if (choice8 == "1")
            {
                Console.WriteLine("You remain seated and wait for Tom to return.");
            }
            else if (choice8 == "2") 
            {
                string title = @" ____________________
|  o  | ,----------, |
|_____| |_===___O__| |
|  o  | | ... ### .| |   
|_____|_|_O__ooo___|_|   
 (_)              (_)";
                Console.WriteLine(title);
                Console.WriteLine("You walk around the living room and find a strange cabinet with FOUR skeleton statues resting on top of it.");
                Items.UnlockCabinet();
            }
            else
            {
                Console.Clear();
                ExploreApartment();
            }

        }
    }
}
