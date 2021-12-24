namespace NetIntermedio.IComparable
{
    public class Rectangulo : System.IComparable
    {
        public Rectangulo(double ancho, double alto)
        {
            _ancho = ancho;
            _alto = alto;
            CalcularArea();
        }

        public override string ToString()
        {
            return $"{_ancho}x{_alto}={_area}";
        }

        public int CompareTo(object obj)
        {
            Rectangulo rectanguloTemp = (Rectangulo)obj;

            if (_area > rectanguloTemp._area)
                return 1;

            if (_area < rectanguloTemp._area)
                return -1;

            return 0;
        }

        private void CalcularArea()
        {
            _area = _ancho * _alto;
        }

        private double _ancho;
        private double _alto;
        private double _area;
    }
}
