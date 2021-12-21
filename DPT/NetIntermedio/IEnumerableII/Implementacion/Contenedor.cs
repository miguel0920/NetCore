using System.Collections;

namespace NetIntermedio.IEnumerableII.Implementacion
{
    public class Contenedor : IEnumerable
    {
        private int[] enteros;
        public Contenedor()
        {
            enteros = new int[4];
            for (int i = 0; i < 4; i++)
            {
                enteros[i] = i * 10;
            }
        }
        public IEnumerator GetEnumerator()
        {
            return (new ContenedoraEnumerador(enteros));
        }
    }

    public class ContenedoraEnumerador : IEnumerator
    {
        private int[] _arreglo;
        private int position = -1;
        public ContenedoraEnumerador(int[] arreglo)
        {
            _arreglo = arreglo;
        }
        public object Current => _arreglo[position];

        public bool MoveNext()
        {
            position++;
            return position < _arreglo.Length;
        }

        public void Reset()
        {
            position = -1;
        }
    }
}