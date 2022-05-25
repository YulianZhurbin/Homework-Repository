using System;

namespace _204_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Player sony = new Player();

            IPlayable sonyPlayer = sony;

            sonyPlayer.Play();

            IRecordable sonyRecorder = sony;

            sonyRecorder.Record();

            sonyPlayer.Stop();

            sonyRecorder.Pause();

            Console.ReadKey();
        }
    }
}
