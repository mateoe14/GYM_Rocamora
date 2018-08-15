using System;


public class Producto
{
    //ATRIBUTOS
    private String nombre;
    private float precio;
    private int stock;
    private String descripcion;
    private Boolean activo;
    private int codProducto;
    private TipoProducto tipo;

    //CONSTRUCTOR
    public Producto(){}

    public Producto(String pNombre, float pPrecio, int pStock, String pDescripcion, Boolean pActivo, int pCodProducto, TipoProducto pTipo)
    {
        this.nombre = pNombre;
        this.precio = pPrecio;
        this.stock = pStock;
        this.descripcion = pDescripcion;
        this.activo = pActivo;
        this.codProducto = pCodProducto;
        this.tipo = pTipo;
    }
}