using System;

namespace SOLID.SingletonResponsibility.Refactor.Example2
{
    public class Player
    {
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

        private int _id;
        private string _name;
        private int _win;
        private int _lose;
        private DateTime _dateTime;
    }
}