using System;
using System.Collections.Generic;

namespace SOLID.Liskov
{
    public class ImplementacionLiskov
    {
        public static void ImplementacionLiskovConsole()
        {
            Console.WriteLine("Liskov incorrecto ejemplo 1");
            Wrong.Example1.Noticiero noticiero = new("Hola Caracol");
            noticiero.Muestra();

            Wrong.Example1.Radio radio = new("Como estas ?");
            radio.Muestra();

            Console.WriteLine("*--------*");

            //Sustituimos la clase hija y vemos como se comportan
            //Nota: "Estamos probando polimorfismo" => Deberia ser de tipo Radio.

            Wrong.Example1.Noticiero sustitucion = new Wrong.Example1.Radio("Estamos probando polimorfismo");
            sustitucion.Muestra();

            // Liskov Correcto 
            Console.WriteLine("\n Liskov correcto ejemplo 1");

            Refactor.Example1.Transmision noticieroRefactor = new Refactor.Example1.Noticiero("Hola RCN");
            noticieroRefactor.Muestra();

            Refactor.Example1.Transmision radioRefactor = new Refactor.Example1.Radio("Como estas ?");
            radioRefactor.Muestra();


            Console.WriteLine("\n Liskov incorrecto ejemplo 2");
            List<Wrong.Example2.Court> courts = new();
            courts.Add(new Wrong.Example2.WimbledonCourt());
            courts.Add(new Wrong.Example2.AustraliaOpen());
            courts.Add(new Wrong.Example2.RolandGarrosCourt());
            foreach (var item in courts)
            {
                item.CutGrass();
            }
        }
    }
}