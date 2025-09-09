using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public delegate void SondEventHandler(string songTitle);

namespace InteractiveMusicPlayerApplication
{
    public class MusicPlayer
    {
        public event SondEventHandler SongPlayed;
        public event SondEventHandler SongPaused;
        public event SondEventHandler SongStopped;
        public event SondEventHandler SongSkipped;

        public void Play(string songTitle) => SongPlayed?.Invoke(songTitle);
        public void Pause(string songTitle) => SongPaused?.Invoke(songTitle);
        public void Stop(string songTitle) => SongStopped?.Invoke(songTitle);
        public void Skip(string songTitle) => SongSkipped?.Invoke(songTitle);
    }
}
