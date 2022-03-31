using System;
using System.Collections.Generic;

namespace CL_Project
{
    public class Movies
    {
        //Option Add To List
        public void AddFilm(string filename)
        {
            string title = Console.ReadLine().ToString();

            Files.WriteJSON(filename, title);

            Console.WriteLine("\n" + title + " Added To List! \nPress Any Key To Continue!");
            Console.ReadKey();
        }


        //Option Remove From List
        public void RemoveFilm(string filename)
        {
            string title = Console.ReadLine().ToString();

            Files.RemoveJSON(filename, title);
        }


        //Option View List
        public void ViewFilm(string filename)
        {
            List<string> movieList = Files.ReadJSON(filename);

            foreach (string movie in movieList)
            {
                Console.WriteLine(movie);
            }

            Console.WriteLine("\nPress Any Key To Continue!");
            Console.ReadKey();
        }


        //Option Select From List
        public void WhatToWatch(string filename)
        {
            List<string> movieList = Files.ReadJSON(filename);

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
