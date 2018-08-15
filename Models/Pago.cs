using System;

public class Pago
{
    //ATRIBUTOS
    private int nroPago {get; set;}
    private DateTime fechaPago {get; set;}
    private float importe {get; set;}
    private Cuota cuota {get; set;}

    //CONSTRUCTOR
    public Pago(){}

    public Pago(int pNroPago, DateTime pFechaPago, float pImporte)
    {
        this.nroPago = pNroPago;
        this.fechaPago = pFechaPago;
        this.importe = pImporte;
    }
}