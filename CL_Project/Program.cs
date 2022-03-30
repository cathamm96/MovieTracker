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
                        AddFilm(watchList);
                        break;
                    case "2":
                        repeat = true;
                        Console.Clear();
                        Console.WriteLine("What Movie Do You Want To Remove From Your Watch List?");
                        RemoveFilm(watchList);
                        break;
                    case "3":
                        repeat = true;
                        Console.Clear();
                        Console.WriteLine("Here is Your Watch List!");
                        ViewFilm(watchList);
                        break;
                    case "4":
                        repeat = true;
                        Console.Clear();
                        Console.WriteLine("What Movie Do You Want To Add To Your Completed List?");
                        AddFilm(completeList);
                        break;
                    case "5":
                        repeat = true;
                        Console.Clear();
                        Console.WriteLine("Here is Your Completed List!");
                        ViewFilm(completeList);
                        break;
                    case "6":
                        repeat = true;
                        Console.Clear();
                        Console.WriteLine("Here Is A Movie To Watch!");
                        WhatToWatch(watchList);
                        break;
                    case "7":
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
            menu.Add(new KeyValuePair<int, string>(5, "View My Completed List"));
            menu.Add(new KeyValuePair<int, string>(6, "What Should I Watch?"));
            menu.Add(new KeyValuePair<int, string>(7, "All Done!"));

            foreach (KeyValuePair<int, string> kvp in menu)
            {
                Console.WriteLine(kvp.Key + " " + kvp.Value);
            }

            string selection = Console.ReadKey().KeyChar.ToString();

            return selection;
        }


        //Option Add To List
        static void AddFilm(string filename)
        {
            string title = Console.ReadLine().ToString();

            FileIO.WriteJSON(filename, title);

            Console.WriteLine("\n" + title + " Added To List! \nPress Any Key To Continue!");
            Console.ReadKey();
        }


        //Option Remove From List
        static void RemoveFilm(string filename)
        {
            string title = Console.ReadLine().ToString();

            FileIO.RemoveJSON(filename, title);

            Console.WriteLine("\n" + title + " Removed From List! \nPress Any Key To Continue!");
            Console.ReadKey();
        }


        //Option View List
        static void ViewFilm(string filename)
        {
            List<string> movieList = FileIO.ReadJSON(filename);

            foreach (string movie in movieList)
            {
                Console.WriteLine(movie);
            }

            Console.WriteLine("\nPress Any Key To Continue!");
            Console.ReadKey();
        }


        //Option Select From List
        static void WhatToWatch(string filename)
        {
            List<string> movieList = FileIO.ReadJSON(filename);

            if (movieList.Count > 0)
            {
                Random r = new Random();

                int rInt = r.Next(0, movieList.Count);

                Console.WriteLine(movieList[rInt]);
            }

            else
            {
                Console.WriteLine("There Are No Movies In Your Watch List!");
            }

            Console.WriteLine("\nPress Any Key To Continue!");
            Console.ReadKey();
        }

    }
}
