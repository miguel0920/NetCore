using System;

namespace DPT.Prototype
{
    public interface ICuenta : ICloneable
    {
        ICuenta clonar();
    }
}
