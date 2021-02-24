using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TripToLibrary
{
    class Start
    {
        private Stack<Book> Books = new Stack<Book>();
        private List<Book> ListOfBooks = new List<Book>();

        public void Library()
        {
            UI ui = new UI();

            char userInput;
            int usrInput;
            int count;

            //Adding a list of books
            #region
            ListOfBooks.Add(new Book("Laughing at Wall Street", "Chris Camillo"));
            ListOfBooks.Add(new Book("But How Do It Know?","J Clark Scott"));
            ListOfBooks.Add(new Book("The Art of Electronics", "Paul Horowitz"));
            ListOfBooks.Add(new Book("Hacking\t\t", "Jon Erickson"));
            ListOfBooks.Add(new Book("The Book of F#\t", "Dave Fancher"));
            ListOfBooks.Add(new Book("Art of Assembly\t", "Randall Hyde"));
            ListOfBooks.Add(new Book("Game Hacking\t", "Nick Cano"));
            ListOfBooks.Add(new Book("Hacking VoIP\t", "Himanshu Dwivedi"));
            ListOfBooks.Add(new Book("Book of GNS3\t", "Jason C. Neumann"));
            ListOfBooks.Add(new Book("Linux Firewalls\t", "Micheal Rash"));
            ListOfBooks.Add(new Book("TCP/IP Guide\t", "Charles M. Kozierok"));
            ListOfBooks.Add(new Book("PoC||GTFO\t\t", "Manul Laproaig"));
            ListOfBooks.Add(new Book("PoC||GTFO, Volume 2", "Manul Laproaig"));
            ListOfBooks.Add(new Book("PoC||GTFO, Volume 3", "Manul Laproaig"));
            #endregion

            while (true)
            {
                ui.Menu();

                    userInput = Console.ReadKey().KeyChar;

                switch (userInput)
                {
                    case '1':
                        ui.AddBook();

                        count = 0;
                        foreach (Book book in ListOfBooks)
                        {
                            count++;
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("[{0}]", count);
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("\tBook: {0}", book.Title);
                            Console.WriteLine("\t\tAuther: {0}", book.Auther);
                        }

                        ui.AddBookInput();
                        usrInput = InputParse.ParseInt();

                        if (usrInput > 0 && usrInput < ListOfBooks.Count+1)
                        {
                            Books.Push(new Book(ListOfBooks[usrInput-1].Title, ListOfBooks[usrInput-1].Auther));
                            ui.AddedBook();
                        }
                        else
                        {
                            ui.AddBookException();
                        }
                        break;

                    case '2':
                        ui.RemoveBook();

                        count = 0;
                        foreach (Book book in Books)
                        {
                            count++;
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("[{0}]", count);
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("\tBook: {0}", book.Title);
                            Console.WriteLine("\t\tAuther: {0}", book.Auther);
                        }

                        ui.RemoveBookInput();
                        usrInput = InputParse.ParseInt();
                        Stack<Book> tmpBooks = new Stack<Book>();
                        count = 0;
                        if (usrInput > 0 && usrInput < Books.Count + 1)
                        {
                            foreach(Book book in Books)
                            {
                                count++;
                                if(usrInput != count)
                                {
                                    tmpBooks.Push(new Book(book.Title, book.Auther));
                                }
                                else
                                {
                                    ui.RemovedBook();
                                }
                            }
                            Books.Clear();
                            foreach(Book book in tmpBooks)
                            {
                                Books.Push(new Book(book.Title, book.Auther));
                            }
                            tmpBooks.Clear();
                        }
                        else
                        {
                            ui.RemoveBookException();
                        }

                        break;

                    case '3':
                        Console.Clear();
                        count = 0;
                        foreach (Book book in Books)
                        {
                            count++;
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.Write("[{0}]", count);
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("\tBook: {0}", book.Title);
                            Console.WriteLine("\t\tAuther: {0}", book.Auther);
                        }
                        break;

                    case '9':
                        ui.Checkout();
                        count = 0;
                        foreach (Book book in Books)
                        {
                            count++;
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.Write("[{0}]", count);
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("\tBook: {0}", book.Title);
                            Console.Write("\t\tAuther: {0}", book.Auther);
                            Thread.Sleep(150);
                            Console.WriteLine("\t\t[LOANED] \nLending period: 3 month(s)\n");
                        }
                        for(int i = 0; i < count; i++)
                        {
                            Books.Pop();
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case '0':
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Black;
                        Environment.Exit(0);
                        break;

                    default:
                        ui.MenuException();
                        break;
                }
            }
        }
    }
}
