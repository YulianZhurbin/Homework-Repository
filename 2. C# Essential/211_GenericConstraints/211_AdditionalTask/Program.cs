using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _211_AdditionalTask
{
    struct Number
    {
        private int num; 

        public Number(int num)
        {
            this.num = num;
        }

        public int Num
        {
            get
            {
                return num;
            }
        }

    }

    class Lines
    {
        private string line;

        public Lines(string line)
        {
            this.line = line;
        }

        public string Line
        {
            get
            {
                return line;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();

            list.Add("one");
            list.Add("two");
            list.Add(3);
            list.Add(4);

            Number num = new Number(1);

            Lines line = new Lines("line");

            list.Add(num);
            list.Add(line);

            for(int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            Console.ReadKey();
        }
    }
}
