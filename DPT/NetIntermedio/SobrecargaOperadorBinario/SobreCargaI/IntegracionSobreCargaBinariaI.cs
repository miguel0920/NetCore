using System;

namespace NetIntermedio.SobrecargaOperadorBinario.SobreCargaI
{
    public class IntegracionSobreCargaBinariaI
    {
        public static void IntegracionSobreCargaBinariaIConsole()
        {
            Imaginario imaginario1 = new(1, 2);
            Imaginario imaginario2 = new(3, 4);
            Imaginario imaginario3 = new(3, 4);
            Imaginario imaginario4 = new(3, 4);
            Imaginario imr;

            //Hacemos la suma;

            imr = imaginario1 + imaginario2;
            Console.WriteLine($"{imaginario1} + {imaginario2} = {imr}");

            //Hacemos la resta;

            imr = imaginario1 - imaginario2;
            Console.WriteLine($"{imaginario1} - {imaginario2} = {imr}");

            //Hacemos la multiplicación;

            imr = imaginario1 * imaginario2;
            Console.WriteLine($"{imaginario1} * {imaginario2} = {imr}");

            //Hacemos la división;

            imr = imaginario1 / imaginario2;
            Console.WriteLine($"{imaginario1} / {imaginario2} = {imr}");

            //Unuarios
            Console.WriteLine("------------------");
            Console.WriteLine(imaginario1);
            imaginario1++;
            Console.WriteLine(imaginario1);

            Console.WriteLine("------------------");
            Console.WriteLine(imaginario2);
            imaginario2--;
            Console.WriteLine(imaginario2);

            Console.WriteLine("------------------");
            Console.WriteLine(imaginario1);
            imaginario1 += imaginario2;
            Console.WriteLine(imaginario1);

            //Igualdad
            Console.WriteLine("------------------");
            if (imaginario3 == imaginario4)
                Console.WriteLine("Objetos Iguales");

            Console.WriteLine("------------------");
            if (imaginario4 != imaginario1)
                Console.WriteLine("Objetos no iguales");

            // Comparación

            Console.WriteLine("------------------");
            if (imaginario4 < imaginario1)
                Console.WriteLine("im4 es menor");

            Console.WriteLine("------------------");
            if (imaginario1 > imaginario4)
                Console.WriteLine("im1 es mayor");
        }
    }
}