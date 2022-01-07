using System;
using System.IO;

namespace NetIntermedio.Files
{
    public class IntegracionFile
    {
        public static void IntegracionFileConsole()
        {
            FileStream stream;
            Console.WriteLine("1. Para serializar el celular, 2. para leer el celular");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    Console.WriteLine("Marca del celular:");
                    string modelo = Console.ReadLine();
                    Console.WriteLine("Valor del celular:");
                    double precio = Convert.ToDouble(Console.ReadLine());

                    Phone laptop = new(modelo, precio);
                    Console.WriteLine("Celular a serializar");
                    laptop.PhoneDetail();

                    stream = new FileStream("PhoneFile.arc", FileMode.Create, FileAccess.Write, FileShare.None);

                    BinaryWriter binaryWriter = new(stream);

                    string tipo = "Tactil";
                    string SO = "Android";

                    binaryWriter.Write(modelo);
                    binaryWriter.Write(precio);
                    binaryWriter.Write(tipo);
                    binaryWriter.Write(SO);

                    stream.Close();
                    break;
                case "2":
                    Console.WriteLine("----(Deserializar archivo)----");
                    stream = new FileStream("PhoneFile.arc", FileMode.Open, FileAccess.Read, FileShare.None);

                    BinaryReader binaryReader = new(stream);

                    string modeloFile = binaryReader.ReadString();
                    double precioFile = binaryReader.ReadDouble();

                    Phone phone = new(modeloFile, precioFile);

                    string tipoFile = binaryReader.ReadString();
                    string SO_File = binaryReader.ReadString();

                    phone.PhoneDetail();
                    Console.WriteLine(tipoFile);
                    Console.WriteLine(SO_File);

                    stream.Close();
                    break;
                default:
                    break;
            }
        }
    }
}