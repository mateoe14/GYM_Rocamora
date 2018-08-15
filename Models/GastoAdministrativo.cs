using System;

public class GastoAdministrativo
{
    //ATRIBUTOS
    private int cantidad;
    private String descripcion;
    private float precioUnitario;
    private DateTime fecha;

    //CONSTRUCTOR
    public GastoAdministrativo(){}

    public GastoAdministrativo(int pCantidad, String pDescripcion, float pPrecioUnitario, DateTime pFecha)
    {
        this.cantidad = pCantidad;
        this.descripcion = pDescripcion;
        this.precioUnitario = pPrecioUnitario;
        this.fecha = pFecha;
    }

}