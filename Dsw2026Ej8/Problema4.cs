using System;

public class Problema4
{
    public double CalcularPromedio(int? nota1, int? nota2, int? nota3)
    {
        double sumaTotal = 0;
        int cantidadNotasValidas = 0;
        if (nota1.HasValue)
        {
            if (nota1.Value >= 0 && nota1.Value <= 10)
            {
                sumaTotal = sumaTotal + nota1.Value;
                cantidadNotasValidas = cantidadNotasValidas + 1;
            }
        }
         

        if (nota2.HasValue)
        {
            if (nota2.Value >= 0 && nota2.Value <= 10)
            {
                sumaTotal = sumaTotal + nota2.Value;
                cantidadNotasValidas = cantidadNotasValidas + 1;
            }
        }
        if (nota3.HasValue)
        {
            if (nota3.Value >= 0 && nota3.Value <= 10)
            {
                sumaTotal = sumaTotal + nota3.Value;
                cantidadNotasValidas = cantidadNotasValidas + 1;
            }
        }
        if (cantidadNotasValidas == 0)
        {
            return 0;
        }
        double promedio = sumaTotal / cantidadNotasValidas;
        return promedio;
    }
}