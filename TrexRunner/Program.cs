using System;

namespace TrexRunner
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new TrexRunnerGame())
                game.Run();
        }
    }
}

