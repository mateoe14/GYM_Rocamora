public class LineaMovimiento
{
    //ATRIBUTOS
    private int cantidad;
    private float precioUnitario;
    private Movimiento movimiento;
    private Producto producto;

    //CONSTRUCTOR
    public LineaMovimiento(){}

    public LineaMovimiento(int pCantidad, float pPrecioUnitario, Movimiento pMovimiento, Producto pProducto)
    {
        this.cantidad = pCantidad;
        this.precioUnitario = pPrecioUnitario;
        this.movimiento = pMovimiento;
        this.producto = pProducto;
    }

}