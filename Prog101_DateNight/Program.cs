/*
 * [Date Night]
 * By Andrada Iorgulescu, October 25, 2021 
 *
 * This work is a derivative of 
 * "C# Adventure Game" by http://programmingisfun.com, used under CC BY.
 * https://creativecommons.org/licenses/by/4.0/
 * 
 * Environment.Exit(0) code was taken from https://programming-idioms.org/idiom/87/stop-program/3260/csharp
 * 
 * ACSII art taken from https://www.oocities.org/spunk1111/food.htm + https://www.asciiart.eu + http://patorjk.com/software/taag
 */
using System;

namespace DateNight
{
    class Program
    {
        static void Main(string[] args)
        {
            Opening();

            Begin();

            Part1();

            Part2();

            Part3();

            Player.EndGame();
        }

        static void Opening()
        {
            //Change window title
            Console.Title = "Date Night";

            //opening title art
            string title = @"
██████╗  █████╗ ████████╗███████╗    ███╗   ██╗██╗ ██████╗ ██╗  ██╗████████╗
██╔══██╗██╔══██╗╚══██╔══╝██╔════╝    ████╗  ██║██║██╔════╝ ██║  ██║╚══██╔══╝
██║  ██║███████║   ██║   █████╗      ██╔██╗ ██║██║██║  ███╗███████║   ██║   
██║  ██║██╔══██║   ██║   ██╔══╝      ██║╚██╗██║██║██║   ██║██╔══██║   ██║   
██████╔╝██║  ██║   ██║   ███████╗    ██║ ╚████║██║╚██████╔╝██║  ██║   ██║   
╚═════╝ ╚═╝  ╚═╝   ╚═╝   ╚══════╝    ╚═╝  ╚═══╝╚═╝ ╚═════╝ ╚═╝  ╚═╝   ╚═╝   
                                                                            
";
            Console.WriteLine(title);
            Console.Read();
            Console.WriteLine("Press Enter To Continue...");
            Console.ReadKey();
            Console.Clear();
        } 

        static void Begin()
        {
            //begin the game
            Game.StartGame();
            Console.ReadKey();
            Console.Clear();
        } 

        static void Part1()
        {
            //change window title
            Console.Title = "Act 1";
            //opening title art
            string title = @"
 █████╗  ██████╗████████╗     ██╗
██╔══██╗██╔════╝╚══██╔══╝    ███║
███████║██║        ██║       ╚██║
██╔══██║██║        ██║        ██║
██║  ██║╚██████╗   ██║        ██║
╚═╝  ╚═╝ ╚═════╝   ╚═╝        ╚═╝
                                 
";
            Console.WriteLine(title);
            Console.Read();
            Console.WriteLine("Press Enter To Continue...");
            Console.ReadKey();
            Console.Clear();
            //first part of story
            Game.Act1();
            Console.ReadKey();
            Console.Clear();
        } 

        static void Part2()
        {
            //change window title
            Console.Title = "Act 2";
            //opening title art
            string title = @"
 █████╗  ██████╗████████╗    ██████╗ 
██╔══██╗██╔════╝╚══██╔══╝    ╚════██╗
███████║██║        ██║        █████╔╝
██╔══██║██║        ██║       ██╔═══╝ 
██║  ██║╚██████╗   ██║       ███████╗
╚═╝  ╚═╝ ╚═════╝   ╚═╝       ╚══════╝
";
            Console.WriteLine(title);
            Console.Read();
            Console.WriteLine("Press Enter To Continue...");
            Console.ReadKey();
            Console.Clear();
            //second part of story
            Game.Act2();
            Console.ReadKey();
            Console.Clear();
        } 

        static void Part3()
        {
            //change window title
            Console.Title = "Act 3";
            //opening title art
            string title = @"
 █████╗  ██████╗████████╗    ██████╗ 
██╔══██╗██╔════╝╚══██╔══╝    ╚════██╗
███████║██║        ██║        █████╔╝
██╔══██║██║        ██║        ╚═══██╗
██║  ██║╚██████╗   ██║       ██████╔╝
╚═╝  ╚═╝ ╚═════╝   ╚═╝       ╚═════╝ 
";
            Console.WriteLine(title);
            Console.Read();
            Console.WriteLine("Press Enter To Continue...");
            Console.ReadKey();
            Console.Clear();
            //final part of story
            Game.Act3();
            Console.ReadKey();
            Console.Clear();
        } 
    }

}