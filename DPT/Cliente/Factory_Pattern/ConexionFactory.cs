using Cliente.Factory_Pattern.Imple;
using Cliente.Factory_Pattern.Interfaz;

namespace Cliente.Factory_Pattern
{
    public class ConexionFactory
    {
        public IConexion GetConexion(string motor)
        {
            return motor switch
            {
                "SqlServer" => new ConexionSql(),
                "MySql" => new ConexionMySql(),
                _ => new ConexionVacia(),
            };
        }
    }
}