using System;
using System.Collections.Generic;

public class Movimiento
{
    //ATRIBUTOS
    private DateTime fecha;
    private TipoMovimiento tipo;
    private List<LineaMovimiento> lineasMovimiento;

    //CONSTRUCTOR
    public Movimiento(){}

    public Movimiento(DateTime pFecha, TipoMovimiento pTipo, List<LineaMovimiento> pLineasMovimiento )
    {
        this.fecha = pFecha;
        this.tipo = pTipo;
        this.lineasMovimiento = pLineasMovimiento;
    }
}