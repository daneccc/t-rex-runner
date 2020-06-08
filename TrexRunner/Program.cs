using System;

namespace TrexRunner
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
<<<<<<< HEAD
            using (var game = new Game1())
=======
            using (var game = new TrexRunnerGame())
>>>>>>> cbc8c04... Adicionar arquivos de projeto.
                game.Run();
        }
    }
}
