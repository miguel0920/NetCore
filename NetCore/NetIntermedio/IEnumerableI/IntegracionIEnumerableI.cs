namespace NetIntermedio.IEnumerableI
{
    public class IntegracionIEnumerableI
    {
        public static void IntegracionIEnumerableIConsole()
        {
            TiendaAutos tienda = new();
            foreach (var item in tienda)
            {
                item.CalcularTenencia(0.05);
                item.MostrarInformacion();
            }
        }
    }
}