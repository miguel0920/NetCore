﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPT.Prototype
{
    public class CuentaAH : ICuenta
    {
        private string _tipo;
        private double _monto;
        public CuentaAH()
        {
            _tipo = "AHORRO";
        }
        public ICuenta clonar()
        {
            CuentaAH cuenta = null;
            try
            {
                cuenta = (CuentaAH)Clone();
            }
            catch (NotSupportedException ex)
            {
                new Exception(ex.Message);
            }
            return cuenta;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public string CuentaToString()
        {
            return $"Cuenta [tipo= {_tipo}, monto={_monto}]";
        }

        public void SetMonto(double monto)
        {
            _monto = monto;
        }

        public double GetMonto()
        {
            return _monto;
        }
    }
}
