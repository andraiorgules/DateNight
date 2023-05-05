using System;
namespace DateNight
{
    public static class Game
    {
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

        //print out game title and overview
        public static void StartGame()
        {
            Console.WriteLine("Date Night");
            Console.WriteLine("Good Evening Player, are you ready for your date?");
            Player.NameCharacter();
        }

        //part 1 of story
        public static void Act1()
        {

            Player.MeetTom();

            Console.ReadKey();
            Console.WriteLine("...");
            Console.ReadKey();

            Player.ChooseMeal();

            Console.ReadKey();
            Console.WriteLine("...");
            Console.WriteLine("Time flies when you're having fun...");
            Console.WriteLine("...");
            Console.ReadKey();
            Dialog("Will you excuse me for a moment? I must visit the restroom.", "red");
            Console.ReadKey();
            Console.WriteLine("You turned your attention to the small TV that had been playing quietly in the background.");
            Console.ReadKey();
            Console.WriteLine("The news had issued an alert for a serial killer that escaped from prison a few days ago. Today, they finally received an updated photo of him.");
            Console.ReadKey();
            Console.WriteLine("...");
            Console.ReadKey();
            Console.WriteLine("The man in the photo looks exactly like Tom...");
            Console.ReadKey();
            Console.WriteLine("...");
            Console.ReadKey();
            Console.WriteLine("The man in the photo is Tom...");
            Console.ReadKey();
            Console.WriteLine("...");
            Console.ReadKey();

            Villain.GoWalk();
            Console.ReadKey();
            Console.WriteLine("You reluctantly follow Tom out of the restaurant and begin praying for a way to escape.");

        }

        //part 2 of story
        public static void Act2()
        {
            Dialog("What a beautiful evening.", "red");
            Console.ReadKey();
            Dialog("Being out here together, alone, with no one around...", "red");
            Console.ReadKey();
            Dialog("It's truly romantic isn't it?", "red");
            Console.ReadKey();

            Console.WriteLine("As you make your way through the night, you come across an old man selling cotton candy.");
            Console.ReadKey();
            Dialog("Good Evening. Would you like some cotton candy? I need to close up shop, but I still have 2 flavors left: Red and Green. ", "blue");
            string title = @"                ____
              .' /  '.
             /  (  .-'\
            |'.__\/__  |
            |    /\  '.|
             \.-'  )  /
              '.__/_.'";
            Console.WriteLine(title);
            Villain.GetCottonCandy();
            Console.ReadKey();
            Console.WriteLine("You and Tom keep walking.");
            Console.ReadKey();

            Console.WriteLine("You reach a fork in the road.");
            Console.ReadKey();
            Street.ChoosePath();
            Console.WriteLine("You and Tom continue walking.");
            Console.ReadKey();

            Villain.AtDoor();

        }

        //part 3 of story
        public static void Act3()
        {
            Console.WriteLine("You enter Tom's house and pick up a faint whiff of something sweet.");
            Dialog("Please excuse me while I go to the kitchen and prepare the drinks.", "red");

            Apartment.ExploreApartment();
            Console.ReadKey();
            Dialog("I hope I haven't kept you waiting for too long.", "red");
            Console.ReadKey();

            Player.Drink();
            Console.ReadKey();

            Player.Escape();
        }
    }
}
