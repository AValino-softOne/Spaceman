using System;

namespace Spaceman
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] wordarr =  new string[] { "Metallica", "Boxing", "Canelo" };
            Game g=new Game(wordarr);
            Ufo f= new Ufo(); 

            while (true)
            {
              g.Greet();
              g.Display();
              g.Ask();

                  if (g.DidWin())
                  {
                      Console.WriteLine("You won");
                      break;
                  }
                  if (g.DidLose())
                  {
                       Console.WriteLine("You lost");
                        g.Display();

                      break;
                  }

            }

        }
    }
}
