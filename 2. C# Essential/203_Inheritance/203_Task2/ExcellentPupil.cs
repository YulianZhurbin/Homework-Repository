using System;

namespace _203_Task2
{
    class ExcellentPupil : Pupil
    {

        public override void Study()
        {
            Console.WriteLine("Study - excellent");
        }

        public override void Read()
        {
            Console.WriteLine("Read - excellent");
        }

        public override void Write()
        {
            Console.WriteLine("Write - excellent");
        }

        public override void Relax()
        {
            Console.WriteLine("Relax - excellent");
        }
    }
}
