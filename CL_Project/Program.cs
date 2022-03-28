using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CL_Project
{
    class Program
    {
        static void Main()
        {
            bool repeat = true;

            while (repeat == true)

            {
                string selection = DisplayMenu();

                switch (selection)
                {
                    case "1":
                        RunAddFilmWatch();
                        break;
                    case "2":
                        RunRemoveFilmWatch();
                        break;
                    case "3":
                        RunViewFilmWatch();
                        break;
                    case "4":
                        RunAddFilmCompleted();
                        break;
                    case "5":
                        RunViewCompleted();
                        break;
                    case "6":
                        RunWhatToWatch();
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

            string selection = Convert.ToString(Console.ReadLine());

            return selection;
        }


        //Writing to Json
        public static class JsonFileUtils
        {
            private static readonly JsonSerializerOptions _options =
                new() { DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull };

            public static void JsonWrite(object obj, string fileName)
            {
                var options = new JsonSerializerOptions(_options)
                {
                    WriteIndented = true
                };
                string jsonString = JsonSerializer.Serialize(obj, options);
                File.WriteAllText(fileName, jsonString);
            }
        }


        //Option 1: Add Film To Watch List
        static void RunAddFilmWatch()
        {
            Console.WriteLine("What Movie Do You Want To Add To Your Watch List?");

            Movies newmovie = new();

            newmovie.Title = Console.ReadLine().ToString();

            var fileName = "WatchList.json";

            JsonFileUtils.JsonWrite(newmovie, fileName);
        }


        //Option 2: Remove Film From Watch List
        static void RunRemoveFilmWatch()
        {
            Console.WriteLine("What Movie Do You Want To Remove From Your Watch List?");
        }


        //Option 3: View Watch List
        static string RunViewFilmWatch()
        {
            Console.WriteLine("Here is Your Watch List!");

            string fileName = "WatchList.json";

            string jsonContents = File.ReadAllText(fileName);

            string jsonString = JsonSerializer.Deserialize<Movies>(jsonContents);

            return jsonString;
        }


        //Option 4: Add Film To Completed List
        static void RunAddFilmCompleted()
        {
            Console.WriteLine("What Movie Did You Watch?");

            Movies completemovie = new();

            completemovie.Title = Console.ReadLine().ToString();

            var fileName = "CompletedList.json";
         
            JsonFileUtils.JsonWrite(completemovie, fileName);
        }


        //Option 5: View Completed List
        static void RunViewCompleted()
        {
            Console.WriteLine("Here Are The Movies You've Watched!");
        }


        //Option 6: What Movie To Watch
        static void RunWhatToWatch()
        {
            Console.WriteLine("This Is What You Should Watch!");
        }

    }
}
