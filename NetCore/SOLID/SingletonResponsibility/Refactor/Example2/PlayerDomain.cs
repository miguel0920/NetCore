using System;

namespace SOLID.SingletonResponsibility.Refactor.Example2
{
    public class PlayerDomain
    {
        public double WinPorcentage(Player player)
        {
            return Convert.ToDouble(player.Win / player.Win + player.Lose);
        }

        public double LosePorcentage(Player player)
        {
            return 0.0;
        }
    }
}