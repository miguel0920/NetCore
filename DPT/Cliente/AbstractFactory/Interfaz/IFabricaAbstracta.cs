namespace Cliente.AbstractFactory.Interfaz
{
    public interface IFabricaAbstracta
    {
        IConexionBD GetConexionBD(string motor);
        IConexionRest GetConexionRest(string url);
    }
}
