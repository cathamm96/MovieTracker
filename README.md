# MovieTracker

By Cat Hamm

Movie Tracker is a console application for users to keep track of both the movies they want to see, as well as ones they have already watched. The Tracker features the ability to add movies to the Watch List and the remove them once they have watched the movie or if they change their mind about wanting to see it. If they do watch the movie and remove it from the Watch List, the user then also has the opportunity to add the movie to the Completed List and track all the movies they have watched. This helps with the dreaded "What is your favorite movie?" inquiry that cause everyone to immediately forget every movie they have ever seen. Finally, the app has a function for anyone not sure what they want to watch. Option 6 in the menu will present the user with a movie randomly selected from their watch list. If they don't want to watch that movie, they can try for another random result!

<b>FUNCTIONS / METHODS</b>

DISPLAY MENU: The Display Menu Function displays a Key Value Pair menu with seven options for the user. There is a Console.Clear line at the beginning to keep the app organized and not overwhelming to anyone cycling through multiple options.

ADD FILM: This references WriteJSON to allow users to add films to their lists. Depending on the file name referenced in the function, the film will either be added to WatchList.json (menu option 1), or CompletedList.json (menu option 4).

REMOVE FILM: The Remove Film option is only applicable to WatchList.json and enables the user to remove a film from their Watch List after seeing the movie, or deciding not to see it. 

VIEW FILM: Like the Add Film function, this applies to both the Watch List and Completed List. It references WatchList.json in menu option 3 to display the Watch List to the user and references CompletedList.json in menu Option 5 to display that list.

WHAT TO WATCH: This acts in a unique way to the other functions. If the user wants to watch a movie, but cannot decide what to watch, this function will read WatchList.json, then generate a random number between 1 and the number of items in the Watch List, and will then return one movie for the user to watch.

WRITEJSON: This function will add the user input of a movie title to a list and then serialize it into one of the JSON files depending on the menu option selected.

REMOVE JSON: This function will remove the user input of a movie title from their Watch List.

READ JSON: This function will deserialize the JSON file referenced in the menu option and return a list of movies from that file to the user.

<b>CLASS / OBJECT</b>

FILES: The Files class contains the relevant code for the WriteJSON, RemoveJSON, and ReadJSON functions. 

<b>FEATURES</b>

MASTER LOOP: The app has a master loop which enables the user to return to the main menu at the end of a selection by pressing any key. They can cycle through as many options as they like before using Option 7 to break the loop and exit the app.

SWITCH STATEMENT: The switch statement follows the menu and provide a case for each option presented in the menu. Cases 1-6 will continue the master loop and return various functions depending on the option selected. Option 7 will break the master loop to exit the app.

LIST CREATION: The app contains a list called movieList found within the Files class. This list is created within the JSON files and is referenced in both the View Watch List and View Completed List options in the menu. Which list is returned is dependent on which file name is referenced. The list is also referenced in Option 6, when the Watch List file is referenced to return a random movie option to the user.

JSON FILES: Movie Tracker has options to write to two separate JSON files, remove items from one of those files, and options to view each of the files. The JSON files are read in order to view both the Watch List and Completed List, and the Watch List is also read in Option 6 before a random item from it is selected and returned to the user.
