using System;
using System.IO;

namespace NetIntermedio.Stream
{
    public class IntegracionStream
    {
        public static void IntegracionStreamConsole()
        {
            FileStream file = new("datos.txt", FileMode.Open, FileAccess.Read, FileShare.None);
            Console.WriteLine($"Longitud archivo {file.Length}");

            //Lectura byte por byte

            for (int i = 0; i < file.Length; i++)
            {
                file.Seek(i, SeekOrigin.Begin);
                var valor = file.ReadByte();
                Console.Write($" {(char)valor} ");
            }

            // Lectura del último al primero

            Console.WriteLine("\n--------------------------------\n");

            for (int j = 1; j <= file.Length; j++)
            {
                file.Seek(-j, SeekOrigin.End);
                var valor = file.ReadByte();
                Console.Write($" {(char)valor} ");
            }

            Console.WriteLine("\n--------------------------------\n");

            //Sin conocer la longitud
            int valor1;
            file.Seek(0, SeekOrigin.Begin);
            while ((valor1 = file.ReadByte()) > 0)
            {
                Console.Write($" {(char)valor1} ");
            }

        }
    }
}