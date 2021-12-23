using Cliente.AbstractFactory.Interfaz;

namespace Cliente.AbstractFactory
{
    public class FabricaProducto
    {
		public static IFabricaAbstracta GetFactory(string tipoFabrica)
		{
			return tipoFabrica switch
			{
				"BD" => new ConexionBDFabrica(),
				"REST" => new ConexionRestFabrica(),
				_ => null
			};
		}
	}
}