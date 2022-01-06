using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;

namespace NetIntermedio.Serialization
{
    public class IntegracionSerialization
    {
        public static void IntegracionSerializationSOAPConsole()
        {
            SoapFormatter formatter = new();
            System.IO.Stream stream;
            Console.WriteLine("1. Para serializar el laptop, 2. para leer la laptop");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    Console.WriteLine("Marca de la laptop:");
                    string marca = Console.ReadLine();
                    Console.WriteLine("Valor de la laptop:");
                    double precio = Convert.ToDouble(Console.ReadLine());

                    Laptop laptop = new(marca, precio);
                    Console.WriteLine("Laptop a serializar (Soap)");
                    laptop.MostrarDetalle();

                    stream = new FileStream("LaptopSOAP.aut", FileMode.Create, FileAccess.Write, FileShare.None);

                    formatter.Serialize(stream, laptop);

                    stream.Close();
                    break;
                case "2":
                    Console.WriteLine("----(Deserializar)----");
                    stream = new FileStream("LaptopSOAP.aut", FileMode.Open, FileAccess.Read, FileShare.None);

                    var laptopDeserialize = (Laptop)formatter.Deserialize(stream);

                    stream.Close();
                    Console.WriteLine("Laptop deserializado");
                    laptopDeserialize.MostrarDetalle();

                    break;
                default:
                    break;
            }
        }

        public static void IntegracionSerializationXMLConsole()
        {
            XmlSerializer formatter;
            System.IO.Stream stream;
            Console.WriteLine("1. Para serializar el laptop, 2. para leer la laptop");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    Console.WriteLine("Marca de la laptop:");
                    string marca = Console.ReadLine();
                    Console.WriteLine("Valor de la laptop:");
                    double precio = Convert.ToDouble(Console.ReadLine());

                    Laptop laptop = new();
                    laptop.Marca = marca;
                    laptop.Precio = precio;
                    Console.WriteLine("Laptop a serializar (XML)");
                    laptop.MostrarDetalle();

                    formatter = new XmlSerializer(typeof(Laptop));

                    stream = new FileStream("LaptopXML.aut", FileMode.Create, FileAccess.Write, FileShare.None);

                    formatter.Serialize(stream, laptop);

                    stream.Close();
                    break;
                case "2":
                    Console.WriteLine("----(Deserializar)----");
                    stream = new FileStream("LaptopXML.aut", FileMode.Open, FileAccess.Read, FileShare.None);

                    formatter = new XmlSerializer(typeof(Laptop));

                    var laptopDeserialize = (Laptop)formatter.Deserialize(stream);

                    stream.Close();
                    Console.WriteLine("Laptop deserializado");
                    laptopDeserialize.MostrarDetalle();

                    break;
                default:
                    break;
            }
        }
    }
}