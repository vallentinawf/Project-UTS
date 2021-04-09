using System;

namespace Kopilih
{
    class Program
    {
        
        static void Main(string[] args)
        {

            MainMenu kopi = new MainMenu();
            kopi.Greet();
            kopi.MainOrdering();
            kopi.Insert();
            kopi.Conlusing();

        }

    }
}
