using System;
using System.Collections.Generic;

public class Rutina
{
   //ATRIBUTOS
   private String nombre {get; set;}
   private int cantDias {get; set;}
   private DateTime fechaInicio {get; set;}
   private List<Socio> socios {get; set;}
   private List<DetalleRutina> detallesRutina {get; set;}

   //CONSTRUCTOR
   public Rutina(){}

   public Rutina(String pNombre, int pCantDias, DateTime pFechaInicio, List<Socio> pSocios, List<DetalleRutina> pDetallesRutina)
   {
     this.nombre = pNombre;
     this.cantDias = pCantDias;
     this.fechaInicio = pFechaInicio;
     this.socios = pSocios;
     this.detallesRutina = pDetallesRutina;  
   } 
}