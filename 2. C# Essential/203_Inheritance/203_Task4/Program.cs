using System;

namespace _203_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ключ доступа, соответствующий версии Про или Эксперт");
            string keyword = Console.ReadLine();

            DocumentWorker file = new DocumentWorker();
            ProDocumentWorker proFile = new ProDocumentWorker();
            ExpertDocumentWorker expertFile = new ExpertDocumentWorker();

            if (keyword == "pro")
            {
                file = proFile as DocumentWorker;
            }
            else if (keyword == "expert")
            {
                file = expertFile as DocumentWorker;
            }
            else
            {
                ;
            }

            file.OpenDocument();
            file.EditDocument();
            file.SaveDocument();

            // Delay
            Console.ReadKey();
        }
    }
}
