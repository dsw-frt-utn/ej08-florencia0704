using System;
public class Sale
{
    private decimal importe;

    public void SetImporte(decimal valor)
    {
        importe = valor;
    }
    public decimal GetImporte()
    {
        return importe;
    }
    public virtual decimal CalculateTotal()
    {
        return importe;
    }
}

