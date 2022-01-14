using System;

namespace SOLID.Liskov.Wrong.Example2
{
    public class RolandGarrosCourt : Court
    {
        public override void CutGrass()
        {
            throw new NotImplementedException();
        }
    }
}