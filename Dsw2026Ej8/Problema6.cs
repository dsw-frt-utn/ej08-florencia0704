using System;

public class Problema6
{
    public string NormalizarCodigoProducto(string code)
    {
        string codigoNormalizado = code.ToProductCode();

        return codigoNormalizado;
    }
}
