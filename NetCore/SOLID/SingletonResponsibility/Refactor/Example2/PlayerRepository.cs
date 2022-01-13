using System;

namespace SOLID.SingletonResponsibility.Refactor.Example2
{
    public class PlayerRepository
    {
        public void SavePlayer(Player player)
        {
            Console.WriteLine("Jugador guardado");
        }

        public void DeletePlayer(int id)
        {
            Console.WriteLine("Jugador Eliminado");
        }
    }
}