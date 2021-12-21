using NetIntermedio.IEnumerableII.Implementacion;
using System;

namespace NetIntermedio.IEnumerableII
{
    public class IntegracionIEnumerableII
    {
        public static void IntegracionIEnumerableIIConsole()
        {
            Contenedor contenedor = new();
            foreach (var item in contenedor)
            {
                Console.WriteLine(item);
            }
        }
    }
}