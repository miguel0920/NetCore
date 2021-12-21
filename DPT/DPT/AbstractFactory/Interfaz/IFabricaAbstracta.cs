namespace DPT.AbstractFactory.Interfaz
{
    public interface IFabricaAbstracta
    {
        IConexionBD GetConexionBD(string motor);
        IConexionRest GetConexionRest(string url);
    }
}
