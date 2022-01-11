using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Interface.Refactor
{
    public class Fax : IFax
    {
        public void Faxear()
        {
            Console.WriteLine("Envio un fax");
        }

        public void Telefono()
        {
            Console.WriteLine("Marcando a un telefono");
        }
    }
}