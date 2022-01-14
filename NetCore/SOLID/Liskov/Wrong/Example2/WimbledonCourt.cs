using System;

namespace SOLID.Liskov.Wrong.Example2
{
    public class WimbledonCourt : Court
    {
        public override void CutGrass()
        {
            Console.WriteLine("Cortando el cesped en Wimbledon");
        }
    }
}