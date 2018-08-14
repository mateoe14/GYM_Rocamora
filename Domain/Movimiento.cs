public class Movimiento
{
    //ATRIBUTOS
    private Date fecha;
    private TipoMovimiento tipo;
    private List<LineaMovimiento> lineasMovimiento;

    //CONSTRUCTOR
    public Movimiento(){}

    public Movimiento(Date pFecha, TipoMovimiento pTipo, List<LineaMovimiento> pLineasMovimiento )
    {
        this.fecha = pFecha;
        this.tipo = pTipo;
        this.lineasMovimiento = pLineasMovimiento;
    }
}