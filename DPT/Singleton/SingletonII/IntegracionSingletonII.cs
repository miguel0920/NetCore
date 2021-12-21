using Singleton.SingletonII.Implementacion;
using System;

namespace Singleton.SingletonII
{
    public class IntegracionSingletonII
    {
        public static void IntegracionSingletonIIConsole()
        {
            TipoDocumentoSingleton tipoDocumento = TipoDocumentoSingleton.GetInstancia();
            var tipoDocumentos = tipoDocumento.TiposDeDocumentos();
            foreach (var item in tipoDocumentos)
            {
                Console.WriteLine(item);
            }
        }
    }
}