using Cliente.AbstractFactory.Imple;
using Cliente.AbstractFactory.Interfaz;

namespace Cliente.AbstractFactory
{
    public class ConexionBDFabrica : IFabricaAbstracta
    {
        public IConexionBD GetConexionBD(string motor)
        {
            return motor switch
            {
                "SqlServer" => new ConexionSql(),
                "MySql" => new ConexionMySql(),
                _ => new ConexionVacia(),
            };
        }

        public IConexionRest GetConexionRest(string url)
        {
            return null;
        }
    }
}
