using System;

namespace _206_Task3
{ 
        class Book
        {
            public void FindNext(string str)
            {
                Console.WriteLine("Поиск строки : " + str);
            }

            public class Notes
            {
                string[] notes = new string[1];

                int count;

                public void PutNote(string note)
                {
                    count++;

                    if (count == 1)
                    {
                        notes[0] = note;
                    }


                    else
                    {
                        string[] array = new string[count];

                        Array.Copy(notes, array, notes.Length);

                        notes = array;

                        notes[notes.Length - 1] = note;
                    } 
                }

                public void PrintNotes()
                {
                    Console.WriteLine();

                    Console.ForegroundColor = ConsoleColor.Green;

                    for (int i = 0; i < notes.Length; i++)
                    {
                        Console.WriteLine(notes[i]);
                    }

                    Console.ForegroundColor = ConsoleColor.Gray;

                    Console.WriteLine("Counter = {0}", count);
                }
            }
        }
        class Program
    {
        static void Main(string[] args)
        {
            string note, answer;

            Book.Notes notes = new Book.Notes();

            do
            {
                Console.WriteLine("Enter a note");

                note = Console.ReadLine();

                notes.PutNote(note);

                Console.WriteLine("Do you wanna put another one. Enter \"y\", if you do");

                answer = Console.ReadLine();

            } while (answer == "y");

            notes.PrintNotes();

            // Dealy
            Console.WriteLine("Press \"enter\" to exit");
            Console.ReadKey();
        }
    }
}
