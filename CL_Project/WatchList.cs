using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace CL_Project
{
    public class WatchList
    {
        public string saveFile;
        public readonly List<WatchList> movies;

        public WatchList(string saveFilePath)
        {
            saveFile = saveFilePath;
            movies = FileUtility.ReadJsonFile<List<WatchList>>(saveFile);
        }




    }
}
