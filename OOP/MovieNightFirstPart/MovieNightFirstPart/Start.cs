using System;
using System.Collections.Generic;
using System.Text;

namespace MovieNightFirstPart
{
    public class Start
    {
        //Input values
        public int UserInput;
        private bool InputValid; //Checks if input exist

        //Movie attributes
        private int ID;
        private string Title;
        private int Year;
        private string Genre;
        private string Describtion;
        private double Review;

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
                UserInput = parseInput.ParseInt();

                if (UserInput == 0)
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

            uiGraphics.SelectedMovie(Title, Year, Genre, Describtion, Review);
            
            //Getting actors from movie
            foreach(ActorsInMovie actors in MovieManager.GetActorsInMovie())
            {
                if (ID.Equals(actors.Movie_ID))
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
            UserInput = parseInput.ParseInt();

            //Checks if movie exists
            MovieCheck();
        }

        public void MovieCheck()
        {
            UIGraphics uiGraphics = new UIGraphics();

            //Selects a movie if user input = movie
            foreach (Movie movie in MovieManager.GetMovies())
            {
                if (UserInput.Equals(movie.Movie_ID))
                {
                    //Sets data for the selected movie
                    ID = movie.Movie_ID;
                    Title = movie.Movie_Title;
                    Year = movie.Movie_Year;
                    Genre = movie.Movie_Genre;
                    Describtion = movie.Movie_Description;
                    Review = movie.Movie_Review;

                    InputValid = true;
                    break;
                }
                else
                {
                    InputValid = false;
                }
            }

            //If valid continue, else try again
            if (InputValid)
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