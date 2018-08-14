public class Cuota
{
    //ATRIBUTOS
    //private int nroCuota {get; set;};
    private Date fechaEmision {get; set;};
    private String descripcion {get; set;};
    private Float monto {get; set;};
    private Boolean pagada {get; set;};
    private Mes mes {get; set;};
    private int año {get; set;};
    private Socio socio {get; set;};
    private List<Pago> pagos {get; set;};


    //CONSTRUCTORES
    public Cuota(){}

    public Cuota(Date pFechaEmision, String pDescripcion, Float pMonto, Boolean pPagada, Mes pMes, int pAño)
    {
        //this.nroCuota = pNroCuota; //en caso de que sea autoincremental no deberia pasarse como parametro del ctor
        this.fechaEmision = pFechaEmision;
        this.descripcion = pDescripcion;
        this.monto = pMonto;
        this.pagada = pPagada;
        this.mes = pMes;
        this.año = pAño;
        //this.pagos = pPagos;      
    }
}