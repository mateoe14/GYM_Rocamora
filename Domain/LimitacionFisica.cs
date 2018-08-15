using System;

public class LimitacionFisica
{
    //ATRIBUTOS
    private String nombre {get; set;}
    private DateTime fechaOcurrencia {get; set;}
    private DateTime fechaRecuperacion {get; set;}

    //CONSTRUCTOR
    public LimitacionFisica(){}

    public LimitacionFisica(String pNombre, DateTime pFechaOcurrencia, DateTime pFechaRecuperacion)
    {
        this.nombre = pNombre;
        this.fechaOcurrencia = pFechaOcurrencia;
        this.fechaRecuperacion = pFechaRecuperacion;
    }




}