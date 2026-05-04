using System;
public static class Extensions
{
    public static string ToProductCode(this string code)
    {
        if (code == null)
        {
            return "SIN-CODIGO";
        }
        string resultado = code.Trim();
        resultado = resultado.ToUpper();
        resultado = resultado.Replace(" ", "-");

        return resultado;
    }
}