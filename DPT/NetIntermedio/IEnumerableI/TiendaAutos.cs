using NetIntermedio.IEnumerableI.Implementacion;
using System.Collections.Generic;

namespace NetIntermedio.IEnumerableI
{
    public class TiendaAutos
    {
        private readonly List<Auto> disponibles;
        public TiendaAutos()
        {
            disponibles = new List<Auto>
            {
                new Auto("Fit", 50000),
                new Auto("Soul", 4544564),
                new Auto("March", 650000),
                new Auto("Spark", 600050)
            };
        }

        public IEnumerator<Auto> GetEnumerator()
        {
            return disponibles.GetEnumerator();
        }
    }
}