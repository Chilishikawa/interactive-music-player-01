using System;

namespace InteractiveMusicPlayerApplication
{
    internal class Subscriber
    {
        public string Name { get; }
        public Subscriber(string name) => Name = name;

        public void Subscribe(MusicPlayer player)
        {
            player.SongPlayed += msg =>
            Console.WriteLine($"{Name} is now enjoying: {msg}");

            player.SongPaused += msg =>
            Console.WriteLine($"{Name} paused: {msg}");

            player.SongStopped += msg =>
            Console.WriteLine($"{Name} stopped: {msg}");

            player.SongSkipped += msg =>
            Console.WriteLine($"{Name} skipped to: {msg}");
        }
    }
}
