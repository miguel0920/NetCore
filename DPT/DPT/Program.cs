using DPT.AbstractFactory;
using DPT.AbstractFactory.Interfaz;
using DPT.Facade.Facade;
using DPT.Factory_Pattern;
using DPT.Factory_Pattern.Interfaz;
using DPT.Prototype;
using DPT.Singleton.Ejemplo;
using NetIntermedio.IEnumerableI;
using NetIntermedio.IEnumerableII;
using NetIntermedio.Interfaz;
using Singleton.SingletonI;
using Singleton.SingletonII;
using System;

namespace DPT
{
    class Program
    {
        static void Main(string[] args)
        {
            //Con Singleton 1;
            IntegracionSingletonI.IntegracionSingletonIConsole();

            //Con Singleton 2;

            IntegracionSingletonII.IntegracionSingletonIIConsole();

            //Con Factory;

            //ConexionFactory fabrica = new ConexionFactory();
            //IConexion conexion1 = fabrica.GetConexion("Oracle");
            //conexion1.Conexion();
            //conexion1.Desconexion();

            //IConexion conexion2 = fabrica.GetConexion("SqlServer");
            //conexion2.Conexion();
            //conexion2.Desconexion();


            //// Con Abstract Factory
            //IFabricaAbstracta fabricaBD = FabricaProducto.GetFactory("BD");
            //IConexionBD sql = fabricaBD.GetConexionBD("SqlServer");
            //sql.Conexion();

            //IFabricaAbstracta fabricaRest = FabricaProducto.GetFactory("REST");
            //IConexionRest authenticacion = fabricaRest.GetConexionRest("Authentication");
            //authenticacion.PeticionGet("https://youtube.com/api/GetUser");

            ////Con Prototype
            //CuentaAH cuentaAhorro = new();
            //cuentaAhorro.SetMonto(2000);

            //CuentaAH cuentaAhorro2 = cuentaAhorro;

            //CuentaAH cuentaClonada = (CuentaAH)cuentaAhorro.clonar();
            //if (cuentaClonada != null)
            //{
            //    Console.WriteLine(cuentaClonada.CuentaToString());
            //    Console.WriteLine(cuentaAhorro2.CuentaToString());
            //}

            //Console.WriteLine(cuentaClonada == cuentaAhorro);

            ////Facade
            //CheckFacade cliente1 = new CheckFacade();
            //cliente1.Buscar("02-08-2021", "02-10-2021", "Bogota", "Medellin");

            ////CheckFacade cliente1 = new CheckFacade();
            ////cliente1.Buscar("02-08-2021", "02-10-2021", "Bogota", "Medellin");

            //// Polimorfismo con interfaces
            //IntegracionInterfaz.IntegracionInterfazConsole();

            // IEnumerable
            TiendaAutos tienda = new();
            foreach (var item in tienda)
            {
                item.CalcularTenencia(0.05);
                item.MostrarInformacion();
            }

            IntegracionIEnumerableII.IntegracionIEnumerableIIConsole();
        }
    }
}