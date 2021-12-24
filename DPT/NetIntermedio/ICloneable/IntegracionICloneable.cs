using NetIntermedio.ICloneable.Implementacion;

namespace NetIntermedio.ICloneable
{
    public class IntegracionICloneable
    {
        public static void IntegracionICloneableConsole()
        {
            Coche coche = new("March", 17000);

            Coche coche1 = coche;

            coche.CalcularTenencia(0.5);
            coche1.CalcularTenencia(0.5);

            coche.MostrarInformacion();
            coche1.MostrarInformacion();

            coche.Costo = 25000;

            coche.MostrarInformacion();
            coche1.MostrarInformacion();

            //*******************ICloneable**********************

            Coche coche2 = new("March", 17000);

            Coche coche3 = (Coche)coche2.Clone();

            coche2.CalcularTenencia(0.5);
            coche3.CalcularTenencia(0.5);

            coche2.Costo = 3;

            coche2.MostrarInformacion();
            coche3.MostrarInformacion();
        }
    }
}