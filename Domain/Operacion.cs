public class Operacion
{
    //ATRIBUTOS
    private String nombre {get; set;};
    private Date fechaOperacion {get; set;};
    private Date fechaAltaMedica {get; set;};

    //CONSTRUCTOR
    public Operacion(){}

    public Operacion(String pNombre, Date pFechaOperacion, Date pFechaAltaMedica)
    {
        this.nombre = pNombre;
        this.fechaOperacion = fechaOperacion;
        this.fechaAltaMedica = pFechaAltaMedica;
    }




}