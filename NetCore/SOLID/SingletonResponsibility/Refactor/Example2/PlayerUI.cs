using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SingletonResponsibility.Refactor.Example2
{
    public class PlayerUI
    {
        public void ShowPlayerHD(Player player)
        {
            Console.WriteLine("Jugador en HD");
        }

        public void ShowPlayer(Player player)
        {
            Console.WriteLine("Jugador en Normal");
        }
    }
}