using System;

namespace SOLID.Liskov
{
    public class ImplementacionLiskov
    {
        public static void ImplementacionLiskovConsole()
        {
            Console.WriteLine("Liskov incorrecto");
            Wrong.Noticiero noticiero = new("Hola Caracol");
            noticiero.Muestra();

            Wrong.Radio radio = new("Como estas ?");
            radio.Muestra();

            Console.WriteLine("*--------*");

            //Sustituimos la clase hija y vemos como se comportan
            //Nota: "Estamos probando polimorfismo" => Deberia ser de tipo Radio.

            Wrong.Noticiero sustitucion = new Wrong.Radio("Estamos probando polimorfismo");
            sustitucion.Muestra();

            // Liskov Correcto 
            Console.WriteLine("\n Liskov correcto");

            Refactor.Transmision noticieroRefactor = new Refactor.Noticiero("Hola RCN");
            noticieroRefactor.Muestra();

            Refactor.Transmision radioRefactor = new Refactor.Radio("Como estas ?");
            radioRefactor.Muestra();
        }
    }
}