# Interactive Music Player 01

### This is a console application built with delegates and events using .NET Core 9.0

### The application prompts the user for a song title and an action, which could be:
- Play
- Pause
- Stop
- Skip
- Exit

## It consists of three classes:

### MusicPlayer.cs:
Define a SongEventHandler delegate and a MusicPlayer class that declares four events: SongPlayed, SongPaused, SongStopped, and SongSkipped. The class provides Play, Pause, Stop, and Skip methods that invoke the corresponding events if there are subscribers.

### Subscriber.cs:
Define the Subscriber class that subscribes to MusicPlayer events. Each event (SongPlayed, SongPaused, SongStopped, SongSkipped) is handled by a lambda function that prints a custom message with the subscriber's name and the associated song.

### Program.cs:
This is the program's entry point. It creates instances of MusicPlayer and Subscriber, subscribes subscribers to player events, and then allows the user to enter actions (play, pause, stop, skip) in the console. Each action executes the corresponding MusicPlayer method, triggering events that notify subscribers.

### -----------------------------------------------------------------------------------

### Esta es una aplicación de consola creada con delegados y eventos con .NET Core 9.0

### La aplicación pide un título de canción y una acción al usuario que podría ser:
- Play
- Pause
- Stop
- Skip
- Exit

## Consiste de 3 clases:

### MusicPlayer.cs : 
Define un delegado SongEventHandler y una clase MusicPlayer que declara cuatro eventos: SongPlayed, SongPaused, SongStopped y SongSkipped. La clase proporciona métodos Play, Pause, Stop y Skip que invocan los eventos correspondientes si hay suscriptores.

### Subscriber.cs :  
Define la clase Subscriber que se suscribe a los eventos de un MusicPlayer. Cada evento (SongPlayed, SongPaused, SongStopped, SongSkipped) se maneja mediante una función lambda que imprime un mensaje personalizado con el nombre del suscriptor y la canción asociada.

### Program.cs : 
Es el punto de entrada del programa. Crea instancias de MusicPlayer y Subscriber, suscribe a los suscriptores a los eventos del reproductor y luego permite al usuario ingresar acciones (play, pause, stop, skip) en la consola. Cada acción ejecuta el método correspondiente del MusicPlayer, disparando los eventos que notifican a los suscriptores.
