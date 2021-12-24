using System;
using System.Linq;

namespace NetIntermedio.IComparable
{
    public class IntegracionIComparable
    {
        public static void IntegracionIComparableConsole()
        {
            Rectangulo[] rectangulo = new Rectangulo[5];
            rectangulo[0] = new Rectangulo(4, 6);
            rectangulo[1] = new Rectangulo(1, 6);
            rectangulo[2] = new Rectangulo(6, 7);
            rectangulo[3] = new Rectangulo(4, 9);
            rectangulo[4] = new Rectangulo(2, 4);

            rectangulo.ToList().ForEach(x => Console.WriteLine(x));

            Console.WriteLine("------------------------------");

            Array.Sort(rectangulo);

            rectangulo.ToList().ForEach(x => Console.WriteLine(x));
        }
    }
}