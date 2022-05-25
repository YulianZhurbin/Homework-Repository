using System;

namespace _204_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter the name of file");
                string fileName = Console.ReadLine();

                string[] arrayFileName = fileName.Split('.');

                AbstractHandler document = new XMLHandler();

                if (arrayFileName.Length != 2)
                {
                    Console.WriteLine("An unacceptable name of file");
                    continue;
                }
                else
                {                  
                    switch (arrayFileName[1])
                    {
                        case "xml":
                            {
                                break;
                            }
                        case "txt":
                            {
                                document = new TXTHandler();
                                break;
                            }
                        case "doc":
                            {
                                document = new DOCHandler();
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("An unknown format of file");
                                continue;
                            }
                    }
                }

                document.Open();
                document.Create();
                document.Change();
                document.Save();

                Console.WriteLine("\n");
            }
        }
    }
}
