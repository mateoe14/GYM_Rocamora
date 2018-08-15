using System;

public class Operacion
{
    //ATRIBUTOS
    private String nombre {get; set;}
    private DateTime fechaOperacion {get; set;}
    private DateTime fechaAltaMedica {get; set;}

    //CONSTRUCTOR
    public Operacion(){}

    public Operacion(String pNombre, DateTime pFechaOperacion, DateTime pFechaAltaMedica)
    {
        this.nombre = pNombre;
        this.fechaOperacion = fechaOperacion;
        this.fechaAltaMedica = pFechaAltaMedica;
    }




}