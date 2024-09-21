﻿namespace Laboratorio84;
//propiedades con validacion
public class CuentaBancaria
{
    private decimal saldo;

    public decimal Saldo
    {
        get { return saldo; }
        set
        {
            if (value >= 0)
                saldo = value;
            else
                throw new ArgumentException("El saldo no puede ser negativo.");
        }
    }
}
