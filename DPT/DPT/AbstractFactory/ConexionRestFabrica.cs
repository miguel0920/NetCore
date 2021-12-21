using DPT.AbstractFactory.Imple;
using DPT.AbstractFactory.Interfaz;

namespace DPT.AbstractFactory
{
    public class ConexionRestFabrica : IFabricaAbstracta
    {
        public IConexionBD GetConexionBD(string motor)
        {
            return null;
        }

        public IConexionRest GetConexionRest(string url)
        {
            return url switch
            {
                "Authentication" => new ConexionRestAuthentication(),
                _ => new ConexionRestVacia()
            };
        }
    }
}
