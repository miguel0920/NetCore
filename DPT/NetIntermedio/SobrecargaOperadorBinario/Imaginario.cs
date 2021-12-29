using System;

namespace NetIntermedio.SobrecargaOperadorBinario
{
    public class Imaginario : System.IComparable
    {
        public double Entero { get => _entero; set => _entero = value; }
        public double NumeroImaginario { get => _imaginario; set => _imaginario = value; }
        public Imaginario(double entero, double imaginario)
        {
            _entero = entero;
            _imaginario = imaginario;
        }
        private double _entero;
        private double _imaginario;

        public override string ToString()
        {
            if (_imaginario < 0)
                return $"({_entero} {_imaginario}i)";
            else
                return $"({_entero} + {_imaginario}i)";
        }

        /// Sobrecarga de los operadores binarios
        /// a = i1 + i2
        public static Imaginario operator +(Imaginario i1, Imaginario i2)
        {
            double realEntero = i1.Entero + i2.Entero;
            double realImaginario = i1.NumeroImaginario + i2.NumeroImaginario;
            Imaginario imaginario = new(realEntero, realImaginario);
            return imaginario;
        }

        public static Imaginario operator -(Imaginario i1, Imaginario i2)
        {
            double realEntero = i1.Entero - i2.Entero;
            double realImaginario = i1.NumeroImaginario - i2.NumeroImaginario;
            Imaginario imaginario = new(realEntero, realImaginario);
            return imaginario;
        }

        public static Imaginario operator *(Imaginario i1, Imaginario i2)
        {
            double realEntero = (i1.Entero * i2.Entero) - (i1.NumeroImaginario * i2.NumeroImaginario);
            double realImaginario = (i1.Entero * i2.NumeroImaginario) + (i1.NumeroImaginario * i2.Entero);
            Imaginario imaginario = new(realEntero, realImaginario);
            return imaginario;
        }

        public static Imaginario operator /(Imaginario i1, Imaginario i2)
        {
            double realEntero = ((i1.Entero * i2.Entero) + (i1.NumeroImaginario * i2.NumeroImaginario))
                / ((i2.Entero * i2.Entero) + (i2.NumeroImaginario * i2.NumeroImaginario));

            double realImaginario = ((i1.NumeroImaginario * i2.Entero) - (i1.Entero * i2.NumeroImaginario)) /
                ((i2.Entero * i2.Entero) + (i2.NumeroImaginario * i2.NumeroImaginario));

            Imaginario imaginario = new(realEntero, realImaginario);
            return imaginario;
        }

        /// Sobrecarga de los operadores unuarios
        public static Imaginario operator ++(Imaginario i1) => new(i1.Entero + 1, i1.NumeroImaginario + 1);
        public static Imaginario operator --(Imaginario i1) => new(i1.Entero - 1, i1.NumeroImaginario - 1);

        /// Sobrecarga de los operadores iguales

        public override bool Equals(object obj)
        {
            if (obj is Imaginario)
            {
                Imaginario imaginario = (Imaginario)obj;
                if (_imaginario == imaginario.NumeroImaginario && _entero == imaginario.Entero)
                    return true;
            }
            return false;
        }

        public static bool operator ==(Imaginario i1, Imaginario i2) => i1.Equals(i2);
        public static bool operator !=(Imaginario i1, Imaginario i2) => !(i1.Equals(i2));

        // Sobrecarga de los operadores de comparación

        public double Magnitud()
        {
            return Math.Sqrt((_entero * _entero) + (_imaginario * _imaginario));
        }

        public int CompareTo(object obj)
        {
            if (obj is Imaginario imaginario)
            {
                if (Magnitud() > imaginario.Magnitud())
                    return 1;
                if (Magnitud() < imaginario.Magnitud())
                    return -1;
            }
            return 0;
        }

        public static bool operator <(Imaginario i1, Imaginario i2) => i1.CompareTo(i2) < 0;
        public static bool operator >(Imaginario i1, Imaginario i2) => i1.CompareTo(i2) > 0;

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}