using System;
using System.Collections.Generic;

public class Musculo
{
    //ATRIBUTOS
    private String nombre {get; set;}
    private List<Ejercicio> ejercicios {get; set;}

    //CONSTRUCTOR
    public Musculo(){}

    public Musculo(String pNombre, List<Ejercicio> pEjercicios)
    {
        this.nombre = pNombre;
        this.ejercicios = pEjercicios;
    }




}