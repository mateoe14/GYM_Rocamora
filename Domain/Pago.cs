public class Pago
{
    //ATRIBUTOS
    private int nroPago {get; set;};
    private Date fechaPago {get; set;};
    private Float importe {get; set;};
    private Cuota cuota {get; set;};

    //CONSTRUCTOR
    public Pago(){}

    public Pago(int pNroPago, Date pFechaPago, Float pImporte)
    {
        this.nroPago = pNroPago;
        this.fechaPago = pFechaPago;
        this.importe = pImporte;
    }
}