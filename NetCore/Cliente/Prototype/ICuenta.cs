using System;

namespace Cliente.Prototype
{
    public interface ICuenta : ICloneable
    {
        ICuenta clonar();
    }
}
