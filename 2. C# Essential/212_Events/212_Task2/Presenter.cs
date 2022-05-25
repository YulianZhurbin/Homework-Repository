using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _212_Task2
{
    public class Presenter
    {
        private Model model;
        private Program view;

        public Presenter()
        {
            model = new Model();
            Program.TextAdd += Program_TextAdd;
        }

        private void Program_TextAdd(string str)
        {
            Console.WriteLine(model.Logic(str));
        }
    }
}