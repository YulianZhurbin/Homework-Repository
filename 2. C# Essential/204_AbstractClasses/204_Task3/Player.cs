using System;

namespace _204_Task3
{
    class Player : IPlayable, IRecordable
    {
        public void Play()
        {
            Console.WriteLine("The player is playing");
        }

        void IPlayable.Pause()
        {
            Console.WriteLine("The player's been paused");
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("The player's been stopped");
        }

        public void Record()
        {
            Console.WriteLine("The recorder is recording");
        }

        void IRecordable.Pause()
        {
            Console.WriteLine("The recorder's been paused");
        }

        void IRecordable.Stop()
        {
            Console.WriteLine("The recorder's been stopped");
        }

    }
}
