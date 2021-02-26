using System;
using System.Collections.Generic;
using System.Text;

namespace MovieNightFirstPart
{
    class Start
    {
        //Input values
        public int userInput;
        private bool inputValid;

        //Movie attributes
        private int id;
        private string title;
        private int year;
        private string genre;
        private string describtion;
        private double review;

        public void Menu()
        {
            UIGraphics uiGraphics = new UIGraphics();
            ParseInput parseInput = new ParseInput();

            while (true)
            {
                //Displays menu graphics
                uiGraphics.Menu();

                //Outputs movies
                foreach (Movie movie in MovieManager.GetMovies())
                {
                    uiGraphics.Movies(movie.Movie_ID, movie.Movie_Title);
                }
                Console.WriteLine();

                //Gets userinput using ParseInput(); <--- Checks if input is an int. If not user can correct until input is valid.
                uiGraphics.UserInput();
                userInput = parseInput.ParseInt();

                if (userInput == 0)
                {
                    //Allows user to search for a movie
                    Search();
                }
                else
                {
                    //Checks if movie exists
                    MovieCheck();
                }
            }
        }

        public void SelectedMovie()
        {
            UIGraphics uiGraphics = new UIGraphics();

            //List of actors in movie
            List<int> actorID = new List<int>();

            uiGraphics.SelectedMovie(title, year, genre, describtion, review);
            
            //Getting actors from movie
            foreach(ActorsInMovie actors in MovieManager.GetActorsInMovie())
            {
                if (id.Equals(actors.Movie_ID))
                {
                    actorID.Add(actors.Actor_SID);
                }
            }

            //Outputting actors
            foreach(Actor actor in MovieManager.GetActors())
            {
                for(int i = 0; i < actorID.Count; i++)
                {
                    if (actor.Actor_SID.Equals(actorID[i]))
                    {
                        uiGraphics.ActorsInMovie(actor.Actor_FirstName, actor.Actor_LastName);
                    }
                }
            }
            Console.ReadKey();
            Console.Clear();
        }

        public void Search()
        {
            UIGraphics uiGraphics = new UIGraphics();
            ParseInput parseInput = new ParseInput();

            //User search input
            uiGraphics.Search();
            string search = Console.ReadLine();
            Console.WriteLine();

            //Outputs results
            foreach (Movie movie in MovieManager.Search(search))
            {
                uiGraphics.Movies(movie.Movie_ID, movie.Movie_Title);
            }
            Console.WriteLine();

            //Gets userinput to select movie
            uiGraphics.UserInput();
            userInput = parseInput.ParseInt();

            //Checks if movie exists
            MovieCheck();
        }

        public void MovieCheck()
        {
            UIGraphics uiGraphics = new UIGraphics();

            //Selects a movie if user input = movie
            foreach (Movie movie in MovieManager.GetMovies())
            {
                if (userInput.Equals(movie.Movie_ID))
                {
                    //Sets data for the selected movie
                    id = movie.Movie_ID;
                    title = movie.Movie_Title;
                    year = movie.Movie_Year;
                    genre = movie.Movie_Genre;
                    describtion = movie.Movie_Description;
                    review = movie.Movie_Review;

                    inputValid = true;
                    break;
                }
                else
                {
                    inputValid = false;
                }
            }

            //If valid continue, else try again
            if (inputValid)
            {
                SelectedMovie();
            }
            else
            {
                uiGraphics.InputNotValid();
            }
        }
    }
}