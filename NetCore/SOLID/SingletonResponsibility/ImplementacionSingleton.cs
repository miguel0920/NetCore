using System;

namespace SOLID.SingletonResponsibility
{
    public class ImplementacionSingleton
    {
        public static void ImplementacionSingletonConsole()
        {
            Console.WriteLine($"Responsabilidad unica incorrecta");
            Wrong.Example1.Empleado empleadoWrong = new("Miguel", "Software Developer", 24, 1500.000);
            empleadoWrong.PagarImpuestos();


            Console.WriteLine($"\nResponsabilidad unica correcta");
            Refactor.Example1.Empleado empleadoRefactor = new("Pablo", "Software Developer II", 24, 2500.000);
            Console.WriteLine(empleadoRefactor);
            Refactor.Example1.Hacienda.PagarImpuestos(empleadoRefactor);


            Console.WriteLine($"\nResponsabilidad unica incorrecta 2");
            Wrong.Example2.Player player = new(1, "Miguel", 10, 2, DateTime.Now);

            // Eventos o acciones del usuario deben ir en otra capa o clase.
            player.ShowPlayer(new Wrong.Example2.Player());
            player.ShowPlayerHD(new Wrong.Example2.Player());

            // Datos estadisticos hacen parte del negocio (Dominio) por lo cual debe ir en una capa o clase independiente
            double winPlayer = player.WinPorcentage();
            Console.WriteLine($"porcentaje de partidas ganadas: {winPlayer}");
            double losePlayer = player.LosePorcentage(new Wrong.Example2.Player());
            Console.WriteLine($"porcentaje de partidas perdidas: {losePlayer}");

            // La persistencia de la información debe ir en una capa llamada (Repositorio o persistencia de datos) o clase independiente
            player.SavePlayer(new Wrong.Example2.Player());
            player.DeletePlayer(1);

            Console.WriteLine($"\nResponsabilidad unica correcta 2");

            Refactor.Example2.Player playerRefactor = new(2, "Angel", 12, 3, DateTime.Now);
            
            Refactor.Example2.PlayerUI playerUI = new();
            playerUI.ShowPlayer(playerRefactor);
            playerUI.ShowPlayerHD(playerRefactor);

            Refactor.Example2.PlayerDomain playerDomain = new();
            playerDomain.WinPorcentage(playerRefactor);
            playerDomain.LosePorcentage(playerRefactor);

            Refactor.Example2.PlayerRepository playerRepository = new();
            playerRepository.SavePlayer(playerRefactor);
            playerRepository.DeletePlayer(2);
        }
    }
}