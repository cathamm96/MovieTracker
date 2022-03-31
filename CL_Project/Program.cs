using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CL_Project
{
    class Program
    {
        static void Main()
        {
            Movies movie = new Movies();

            bool repeat = true;

            string watchList = "WatchList.json";
            string completeList = "CompletedList.json";

            while (repeat == true)

            {
                string selection = DisplayMenu();

                switch (selection)
                {
                    case "1":
                        repeat = true;
                        Console.Clear();
                        Console.WriteLine("What Movie Do You Want To Add To Your Watch List?");
                        movie.AddFilm(watchList);
                        break;
                    case "2":
                        repeat = true;
                        Console.Clear();
                        Console.WriteLine("What Movie Do You Want To Remove From Your Watch List?");
                        movie.RemoveFilm(watchList);
                        break;
                    case "3":
                        repeat = true;
                        Console.Clear();
                        Console.WriteLine("Here is Your Watch List!");
                        movie.ViewFilm(watchList);
                        break;
                    case "4":
                        repeat = true;
                        Console.Clear();
                        Console.WriteLine("What Movie Do You Want To Add To Your Completed List?");
                        movie.AddFilm(completeList);
                        break;
                    case "5":
                        repeat = true;
                        Console.Clear();
                        Console.WriteLine("What Movie Do You Want To Remove From Your Completed List?");
                        movie.RemoveFilm(completeList);
                        break;
                    case "6":
                        repeat = true;
                        Console.Clear();
                        Console.WriteLine("Here is Your Completed List!");
                        movie.ViewFilm(completeList);
                        break;
                    case "7":
                        repeat = true;
                        Console.Clear();
                        Console.WriteLine("Here Is A Movie To Watch!");
                        movie.WhatToWatch(watchList);
                        break;
                    case "8":
                        repeat = true;
                        Console.Clear();
                        Console.WriteLine("What Movie Do You Want More Information About?");
                        string movieName = Console.ReadLine();
                        GetMovieInfo.Main(movieName);
                        break;

                    case "9":
                        repeat = false;
                        break;
                }
            }
        }

        static string DisplayMenu()
        {
            var menu = new List<KeyValuePair<int, string>>();

            Console.Clear();

            Console.WriteLine("Welcome To Your Movie Watch List!");
            Console.WriteLine();
            Console.WriteLine("What Do You Want To Do?");
            Console.WriteLine();

            menu.Add(new KeyValuePair<int, string>(1, "Add Movie to Watch List"));
            menu.Add(new KeyValuePair<int, string>(2, "Remove Movie from Watch List"));
            menu.Add(new KeyValuePair<int, string>(3, "View My Watch List"));
            menu.Add(new KeyValuePair<int, string>(4, "Add Movie to Completed List"));
            menu.Add(new KeyValuePair<int, string>(5, "Remove Movie From Completed List"));
            menu.Add(new KeyValuePair<int, string>(6, "View My Completed List"));
            menu.Add(new KeyValuePair<int, string>(7, "What Should I Watch?"));
            menu.Add(new KeyValuePair<int, string>(9, "All Done!"));

            foreach (KeyValuePair<int, string> kvp in menu)
            {
                Console.WriteLine(kvp.Key + " " + kvp.Value);
            }

            string selection = Console.ReadKey().KeyChar.ToString();

            return selection;
        }
    }
}
