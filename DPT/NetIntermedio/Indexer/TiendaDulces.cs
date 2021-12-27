namespace NetIntermedio.Indexer
{
    public class TiendaDulces
    {
        private Dulce[] dulces;
        public TiendaDulces()
        {
            dulces = new Dulce[4];
            dulces[0] = new Dulce("Coffee", 100.00);
            dulces[1] = new Dulce("Bianchi", 200.00);
            dulces[2] = new Dulce("Menta", 50.00);
            dulces[3] = new Dulce("Caramelo", 250.00);
        }

        // Indexer
        public Dulce this[int index]
        {
            get
            {
                if (dulces[index].Valor != 500.00)
                {
                    return dulces[index];
                }
                else
                {
                    return dulces[index] = new Dulce("Dulce no encontrado", 0);
                }
            }
            set { dulces[index] = value; }
        }

        public int ToLength()
        {
            return dulces.Length;
        }
    }
}