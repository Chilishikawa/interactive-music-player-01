using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public delegate void SongEventHandler(string songTitle);

namespace InteractiveMusicPlayerApplication
{
    public class MusicPlayer
    {
        public event SongEventHandler SongPlayed;
        public event SongEventHandler SongPaused;
        public event SongEventHandler SongStopped;
        public event SongEventHandler SongSkipped;

        public void Play(string songTitle) => SongPlayed?.Invoke(songTitle);
        public void Pause(string songTitle) => SongPaused?.Invoke(songTitle);
        public void Stop(string songTitle) => SongStopped?.Invoke(songTitle);
        public void Skip(string songTitle) => SongSkipped?.Invoke(songTitle);
    }
}
