using System;

namespace _207_AdditionalTask
{
    struct Notebook
    {
        string model, producer, price;

        public Notebook(string model, string producer, string price)
        {
            this.model = model;

            this.producer = producer;

            this.price = price;
        }

        public void PrintInfo()
        {
            Console.WriteLine(model + producer + price);
        } 
    }
}
