using System;

public class DetalleRutina
{
    //ATRIBUTOS
    private int dia {get; set;}
    private String seriesxRepeticiones {get; set;}
    private String descanso {get; set;}
    private Musculo musculo {get; set;}

    //CONSTRUCTOR
    public DetalleRutina(){}

    public DetalleRutina(int pDia, String pSeriesxRepeticiones, String pDescanso, Musculo pMusculo )
    {
        this.dia = pDia;
        this.seriesxRepeticiones = pSeriesxRepeticiones;
        this.descanso = pDescanso;
        this.musculo = pMusculo;
    }
}