using System;

namespace SOLID.SingletonResponsibility.Wrong.Example2
{
    public class Player
    {
        public Player()
        {

        }
        public Player(int id, string name, int win, int lose, DateTime dateTime)
        {
            _id = id;
            _name = name;
            _win = win;
            _lose = lose;
            _dateTime = dateTime;
        }

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public int Win { get => _win; set => _win = value; }
        public int Lose { get => _lose; set => _lose = value; }
        public DateTime DateTime { get => _dateTime; set => _dateTime = value; }

        // Una clase solo debe tener un razon para cambiar.
        // Posibles razones para cambiar:

        //******* Inicio - Razon 1 *************
        public double WinPorcentage()
        {
            return Convert.ToDouble(_win / _win + _lose);
        }

        public double LosePorcentage(Player player)
        {
            return 0.0;
        }
        //******* Fin - Razon 1 *************

        //******* Inicio - Razon 2 *************
        public void SavePlayer(Player player)
        {
            Console.WriteLine("Jugador guardado");
        }

        public void DeletePlayer(int id)
        {
            Console.WriteLine("Jugador Eliminado");
        }

        //******* Fin - Razon 2 *************

        //******* Inicio - Razon 3 *************
        public void ShowPlayerHD(Player player)
        {
            Console.WriteLine("Jugador en HD");
        }

        public void ShowPlayer(Player player)
        {
            Console.WriteLine("Jugador en Normal");
        }
        //******* Fin - Razon 3 *************

        private int _id;
        private string _name;
        private int _win;
        private int _lose;
        private DateTime _dateTime;
    }
}