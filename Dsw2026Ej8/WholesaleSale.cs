using System;
public class WholesaleSale : Sale
{
    public override decimal CalculateTotal()
    {
        decimal porcentajeDescuento = 0.10m;
        decimal descuento = GetImporte() * porcentajeDescuento;
        return GetImporte() - descuento;
    }
}
