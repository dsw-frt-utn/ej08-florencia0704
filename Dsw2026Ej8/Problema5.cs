using System;
public class Problema5
{
    public decimal ObtenerImporteFinal(Sale sale)
    {
        decimal total = sale.CalculateTotal();
        return total;
    }
}
