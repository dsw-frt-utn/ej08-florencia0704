using System;

public class Problema3
{
    public string CompararCopias(int originalValue, Product product)
    {
        int copiaValor = originalValue;
        copiaValor++;

        Product copiaReferencia = product;
        copiaReferencia.SetDescription("Descripción Modificada");
        return $"{originalValue}-{copiaValor}-{product.GetDescription()}";
    }
}