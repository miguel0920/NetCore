using NetIntermedio.Delegate.Simple;

namespace NetIntermedio.Delegate
{
    public delegate void DelegateSimple(string mensaje);

    public class IntegracionDelegateISimple
    {
        public static void IntegracionDelegateSimpleConsole()
        {
            DelegateSimple delegateSimple = new(Radio.MensajeRadio);
            delegateSimple("saludos a todos !!");

            delegateSimple = new(Pastel.MensajePastel);
            delegateSimple("harina de trigo");
        }
    }
}