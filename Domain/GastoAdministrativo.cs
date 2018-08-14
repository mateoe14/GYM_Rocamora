public class GastoAdministrativo
{
    //ATRIBUTOS
    private int cantidad;
    private String descripcion;
    private Float precioUnitario;
    private Date fecha;

    //CONSTRUCTOR
    public GastoAdministrativo(){}

    public GastoAdministrativo(int pCantidad, Sring pDescripcion, Float pPrecioUnitario, Date pFecha)
    {
        this.cantidad = pCantidad;
        this.descripcion = pDescripcion;
        this.precioUnitario = pPrecioUnitario;
        this.fecha = pFecha;
    }

}