using System;
using System.Collections.Generic;

namespace CL_Project
{
    public class CompleteList
    {
        private string saveFile;
        private List<CompleteList> watchedmovies;

        public CompleteList(string saveFilePath)
        {
            saveFile = saveFilePath;
            watchedmovies = FileUtility.ReadJsonFile<List<CompleteList>>(saveFile);
        }

    }  
}
