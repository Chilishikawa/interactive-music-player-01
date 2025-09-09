
using InteractiveMusicPlayerApplication;

internal class Program
{
    static void Main()
    {
        MusicPlayer player = new MusicPlayer();
        Suscriber sub1 = new Suscriber("User1");
        Suscriber sub2 = new Suscriber("User2");

        sub1.Suscribe(player);
        sub2.Suscribe(player);

        while (true)
        {
            Console.WriteLine("Enter song title:");
            string title = Console.ReadLine();

            Console.WriteLine("Enter action (play, pause, stop, skip) or 'exit':");
            string action = Console.ReadLine().ToLower();
            if (action == "exit") break;

            switch (action)
            {
                case "play": player.Play(title); break;
                case "pause": player.Pause(title); break;
                case "stop": player.Stop(title); break;
                case "skip": player.Skip(title); break;
                default: Console.WriteLine("Invalid action."); break;
            }
        }
    }
}