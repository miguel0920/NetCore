namespace NetIntermedio.Indexer
{
    public class IntegracionIndexer
    {
        public static void IntegracionIndexerConsole()
        {
            TiendaDulces tienda = new();
            Dulce dulce = tienda[1];
            dulce.MostrarDetalleDulce();

            tienda[1] = new Dulce("Bombom bum", 500.00);

            for (int i = 0; i < tienda.ToLength(); i++)
                tienda[i].MostrarDetalleDulce();
        }
    }
}