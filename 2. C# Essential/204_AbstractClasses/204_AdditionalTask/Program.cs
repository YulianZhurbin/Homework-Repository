using System;

namespace _204_AdditionalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Document title = new Title();

            Document body = new Body();

            Document footer = new Footer();

            title.Content = "War and Peace";
            body.Content = "The book is about a war and peace";
            footer.Content = "The piece of literature is made by Leo Tolstoy";

            title.Show();
            body.Show();
            footer.Show();

            // Delay
            Console.ReadKey();
        }
    }
}
