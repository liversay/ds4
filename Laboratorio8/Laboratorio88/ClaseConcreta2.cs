﻿
namespace Laboratorio88
{


class ClaseConcreta2: ClaseAbstracta
{
    protected override string tomarValor()
    {
        return "ClaseConcreta2";
    }
    public override string prefixValor(string prefix)
    {
        return $"{prefix}ClaseConcreta2";
    }
}

}