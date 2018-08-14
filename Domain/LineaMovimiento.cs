public class LineaMovimiento
{
    //ATRIBUTOS
    private int cantidad;
    private Float precioUnitario;
    private Movimiento movimiento;
    private Producto producto;

    //CONSTRUCTOR
    public LineaMovimiento(){}

    public LineaMovimiento(int pCantidad, Float pPrecioUnitario, Movimiento pMovimiento, Producto pProducto)
    {
        this.cantidad = pCantidad;
        this.precioUnitario = pPrecioUnitario;
        this.movimiento = pMovimiento;
        this.producto = pProducto;
    }

}