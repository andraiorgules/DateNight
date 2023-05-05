using System;
namespace DateNight
{
    public class Street
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

        //player choose between two storyline options
        public static void ChoosePath() 
        {
            string title = @"               )
             (      _[]_         (
     __[]___[]___[]/____\_[]_    )
    /______________|[][]|____\  (
    |[][]|[][]|[][]|[][]|[][]|__[]_
    |  /\|/\  |  /\|  /\|/\  |_____\
    |[]|||||[]|[]|||[]|||||[]|[_]|||
  ===================================
  -  -  -  -  -  -  -  -  -  -  -  -  -
=========================================  ";
            Console.WriteLine(title);
            Dialog("My apartment is just ahead. We can either take the short route, or the scenic route. Which do you prefer?", "red");
            Console.ReadKey();
            Dialog("1. Let's take the short route.", "magenta");
            Dialog("2. Let's take the scenic route.", "magenta");
            string choice5 = Console.ReadLine();
            if (choice5 == "1")
            {
                Console.WriteLine("You and Tom take the short route. However, you can't help but wonder what you would've found along the scenic route.");
                Items.NoKey();
            }
            else if (choice5 == "2")
            {
                string title2 = @"        .     .
    ...  :``..':
     : ````.'   :''::'
   ..:..  :     .'' :
``.    `:    .'     :
    :    :   :        :
     :   :   :         :
     :    :   :        :
      :    :   :..''''``::.
       : ...:..'     .''
       .'   .'  .::::'
      :..'''``:::::::
      '         `::::
                  `::.
                   `::
                    :::.
         ..:.:.::'`. ::'`.  . : : .
       ..'      `:.: ::   :'       .:
      .:        .:``:::  :       .: ::
      .:    ..''     :::.'    :':    :
       : .''         .:: : : '
        :          .'`::
                      ::
                      ::
                      ::
                      ::
                      ::
                      :: ";
                Console.WriteLine(title2);
                Console.WriteLine("You and Tom take the scenic route. On your way, you pass by a large art installation of a DOZEN roses.");
                Console.ReadKey();
                Dialog("That art installation is beautiful. I'll climb up and pick one of the petals for you.", "red");
                Console.ReadKey();
                Console.WriteLine("As Tom climbed up the installation, something fell out of his pocket...");
                Console.ReadKey();
                string title3 = @"  __
               / o\
               \_ /
                <|
                <|
                <|
                `";
                Console.WriteLine(title3);
                Console.WriteLine("You bend down and pick up a key. What should you do next?");
                Dialog("1. Return the key to Tom.", "magenta");
                Dialog("2. Tuck the key into your purse.", "magenta");
                string choice = Console.ReadLine();
                if (choice == "1") 
                {
                    Villain.GiveKey();
                }
                else if (choice == "2") 
                {
                    Items.GetKey();
                }
                else
                {
                    Console.Clear();
                    ChoosePath();
                }

                Dialog("It looks like the petals won't budge. Shall we move on?", "red");
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                ChoosePath();
            }
        }
    }
}




