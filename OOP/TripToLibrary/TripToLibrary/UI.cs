using System;
using System.Collections.Generic;
using System.Text;

namespace TripToLibrary
{
    class UI
    {
        //This region consist of graphics for the user interface.
        #region
        public void Menu()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("===================");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n   The Library   \n");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("===================\n");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Choose the following options:\n");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("[1]");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(" Add Book");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("[2]");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(" Remove Book");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("[3]");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(" Show Books");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n[9]");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(" Lend Books");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("[0]");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(" Exit");

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n[]: ");
            Console.ForegroundColor = ConsoleColor.Blue;

        }

        public void MenuException()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("===================");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("ERROR 404: ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("The option entered, doesn't exist!");
            Console.WriteLine("Please select an option, using the menu below.");
        }

        public void AddBook()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("=================");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n   Add Items   \n");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("=================\n");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Choose one of the following books:\n");
        }

        public void AddBookInput()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n[]: ");
            Console.ForegroundColor = ConsoleColor.Blue;
        }

        public void AddedBook()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("===================");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Sucessfully added book!");
        }

        public void AddBookException()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("===================");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("ERROR 404: ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("The book entered, doesn't exist!");
        }

        public void RemoveBook()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("===================");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n   Romove Book   \n");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("===================\n");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Select a book to remove it:");
        }

        public void RemoveBookInput()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n[]: ");
            Console.ForegroundColor = ConsoleColor.Blue;
        }

        public void RemovedBook()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("===================");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Sucessfully removed book!");
        }

        public void RemoveBookException()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("===================");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("ERROR 404: ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("The book entered, doesn't exist!");
        }

        public void Checkout()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("==================");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n   Lend Books   \n");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("==================\n");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        #endregion
    }
}
