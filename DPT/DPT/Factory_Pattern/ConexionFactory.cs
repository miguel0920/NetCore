using DPT.Factory_Pattern.Imple;
using DPT.Factory_Pattern.Interfaz;

namespace DPT.Factory_Pattern
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