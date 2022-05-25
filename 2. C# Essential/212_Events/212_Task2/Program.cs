﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _212_Task2
{
    public delegate void MyDelegate(string str);

    class Program
    {
        public static event MyDelegate TextAdd;

        static void Main(string[] args)
        {
            new Presenter();
            string str = "";
            while(true)
            {
                str = Console.ReadLine();
                if (!string.IsNullOrEmpty(str))
                {
                    TextAdd.Invoke(str);
                }
            }
        }
    }
}
