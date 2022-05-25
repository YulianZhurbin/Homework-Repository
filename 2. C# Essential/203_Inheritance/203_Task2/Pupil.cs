using System;

namespace _203_Task2
{
    class Pupil
    {
        string name, study, read, write, relax;

        public Pupil(string name, string study, string read, string write, string relax)
        {
            this.study = study;
            this.read = read;
            this.write = write;
            this.relax = relax;
            this.name = name;
            Console.WriteLine(this.name);
            Study();
            Read();
            Write();
            Relax();
        }
        
       public virtual void Study()
        {
            Console.WriteLine($"Study - {study}");
        }

        public virtual void Read()
        {
            Console.WriteLine($"Read - {read}");
        }

        public virtual void Write()
        {
            Console.WriteLine($"Write - {write}");
        }

        public virtual void Relax()
        {
            Console.WriteLine($"Relax - {relax}");
        }
    }
}
