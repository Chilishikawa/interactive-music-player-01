using System;

namespace InteractiveMusicPlayerApplication
{
    internal class Suscriber
    {
        public string Name { get; }
        public Suscriber(string name) => Name = name;

        public void Suscribe(MusicPlayer player)
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
