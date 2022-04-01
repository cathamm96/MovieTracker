# MovieTracker

By Cat Hamm

<b>APPLICATION SUMMARY</B>

Movie Tracker is a console application for users to keep track of both the movies they want to see, as well as ones they have already watched. The Tracker features the ability to add movies to the Watch List and the remove them once they have watched the movie or if they change their mind about wanting to see it. If they do watch the movie and remove it from the Watch List, the user then also has the opportunity to add the movie to the Completed List and track all the movies they have watched. This helps with the dreaded "What is your favorite movie?" inquiry that cause everyone to immediately forget every movie they have ever seen. Finally, the app has a function for anyone not sure what they want to watch. Option 7 in the menu will present the user with a movie randomly selected from their watch list. If they don't want to watch that movie, they can try for another random result!


<b>FUNCTIONS / METHODS</b>

<i>DISPLAY MENU:</i> The Display Menu Function displays a Key Value Pair menu with seven options for the user. There is a Console.Clear line at the beginning to keep the app organized and not overwhelming to anyone cycling through multiple options.

<i>ADD FILM:</i> This references WriteJSON to allow users to add films to their lists. Depending on the file name referenced in the method, the film will either be added to WatchList.json (menu option 1), or CompletedList.json (menu option 4).

<i>REMOVE FILM:</i> The Remove Film option is only applicable to WatchList.json and enables the user to remove a film from their Watch List after seeing the movie, or deciding not to see it. 

<i>VIEW FILM:</i> Like the Add Film method, this applies to both the Watch List and Completed List. It references WatchList.json in menu option 3 to display the Watch List to the user and references CompletedList.json in menu Option 6 to display that list.

<i>WHAT TO WATCH:</i> This acts in a unique way to the other methods. If the user wants to watch a movie, but cannot decide what to watch, this method will read WatchList.json, then generate a random number between 1 and the number of items in the Watch List, and will then return one movie for the user to watch.

<i>WRITEJSON:</i> This function will add the user input of a movie title to a list and then serialize it into one of the JSON files depending on the menu option selected.

<i>REMOVE JSON:</i> This function will remove the user input of a movie title from their Watch List.

<i>READ JSON:</i> This function will deserialize the JSON file referenced in the menu option and return a list of movies from that file to the user.


<b>CLASS / OBJECT</b>

<i>FILES CLASS:</i> Contains the relevant code for the WriteJSON, RemoveJSON, and ReadJSON functions. 

<i>MOVIES CLASS:</i> Contains code for AddFilm, RemoveFilm, ViewFilm, and WhatToWatch methods.

<i>MOVIE OBJECT:</i> Created from Movies class to call the methods within the Display Menu.

<i>MOVIEINFO / MOVIEUTILITY CLASSES:</i> Used for calling the Movie Database API and extracting specific information about a movie from the user's input.

<i>MOVIE INFO OBJECT:</i> Created from MovieUtility Class to call the method in Option 8 of the Display Menu.

<b>FEATURES</b>

<i>MASTER LOOP:</i> The app has a master loop which enables the user to return to the main menu at the end of a selection by pressing any key. They can cycle through as many options as they like before using Option 9 to break the loop and exit the app.

<i>SWITCH STATEMENT:</i> The switch statement follows the menu and provide a case for each option presented in the menu. Cases 1-6 will continue the master loop and return various functions depending on the option selected. Option 9 will break the master loop to exit the app.

<i>LIST CREATION:</i> The app contains a list called movieList found within the Files class. This list is created within the JSON files and is referenced in both the View Watch List and View Completed List options in the menu. Which list is returned is dependent on which file name is referenced. The list is also referenced in Option 7, when the Watch List file is referenced to return a random movie option to the user.

<i>JSON FILES:</i> Movie Tracker has options to write to two separate JSON files, remove items from one of those files, and options to view each of the files. The JSON files are read in order to view both the Watch List and Completed List, and the Watch List is also read in Option 7 before a random item from it is selected and returned to the user.

<i>WEB API:</i> Menu Option 8 uses The Movie Database API to return the tagline, overview, and original language of a movie title entered by the app user, so they can use that information to decide if the movie will go on their Watch List.
