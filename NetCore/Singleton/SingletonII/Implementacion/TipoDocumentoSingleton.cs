using Singleton.SingletonII.Model;
using System.Collections.Generic;

namespace Singleton.SingletonII.Implementacion
{
    public class TipoDocumentoSingleton
    {
        public static TipoDocumentoSingleton GetInstancia() => instancia == null ? new TipoDocumentoSingleton() : instancia;

        public List<TipoDocumento> TiposDeDocumentos()
        {
            if (tipoDocumentos == null)
            {
                tipoDocumentos = new List<TipoDocumento>
                {
                    new TipoDocumento("Cedula", "CC"),
                    new TipoDocumento("Pasaporte", "PP")
                };
            }
            return tipoDocumentos;
        }

        private TipoDocumentoSingleton() { }
        private static readonly TipoDocumentoSingleton instancia;
        private static List<TipoDocumento> tipoDocumentos;
    }
}