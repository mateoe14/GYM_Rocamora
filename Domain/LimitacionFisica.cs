public class LimitacionFisica
{
    //ATRIBUTOS
    private String nombre {get; set;};
    private Date fechaOcurrencia {get; set;};
    private Date fechaRecuperacion {get; set;};

    //CONSTRUCTOR
    public Operacion(){}

    public Operacion(String pNombre, Date pFechaOcurrencia, Date pFechaRecuperacion)
    {
        this.nombre = pNombre;
        this.fechaOcurrencia = pFechaOcurrencia;
        this.fechaRecuperacion = pFechaRecuperacion;
    }




}