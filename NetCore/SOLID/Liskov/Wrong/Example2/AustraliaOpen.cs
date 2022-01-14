using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Liskov.Wrong.Example2
{
    public class AustraliaOpen : Court
    {
        public override void CutGrass()
        {
            throw new NotImplementedException("Tierra batida no tiene cesped que cortar");
        }
    }
}