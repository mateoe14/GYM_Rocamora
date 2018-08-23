using System;
using System.Collections.Generic;

public class FichaMedica
{
   //ATRIBUTOS
   private System.DateTime fechaEntrega;
   private float peso;
   private float altura;
   private String grupoSanguineo;
   private Boolean hipertensionArterial;
   private Boolean diabetes;
   private Boolean afeccionCardioVascular;
   private Boolean afeccionRespiratoria;
   private Boolean fuma;
   private Boolean alcohol;
   private List<Medicacion> medicaciones;
   private List<Enfermedad> enfermedades;
   private List<LimitacionFisica> limitacionesFisicas;
   private List<Operacion> operaciones;
   private List<ActividadFisica> actvidadesFisicas;

   //CONSTRUCTORES
   public FichaMedica(){}

	public FichaMedica(DateTime pFechaEntrega, float pPeso, float pAltura, String pGrupoSanguineo, Boolean pHipertensionArterial, Boolean pDiabetes, Boolean pAfeccionCardioVascular, Boolean pAfeccionRespiratoria, Boolean pFuma, Boolean pAlcohol, List<Medicacion> pMedicaciones, List<Enfermedad> pEnfermedades, List<LimitacionFisica> pLimitacionesFisicas, List<Operacion> pOperaciones, List<ActividadFisica> pActividadesFisicas)
   {
        this.fechaEntrega = pFechaEntrega;
		this.altura = pAltura;
        this.peso = pPeso;
        this.grupoSanguineo = pGrupoSanguineo;
        this.hipertensionArterial = pHipertensionArterial;
        this.diabetes = pDiabetes;
        this.afeccionCardioVascular = pAfeccionCardioVascular;
        this.afeccionRespiratoria = pAfeccionRespiratoria;
        this.fuma = pFuma;
        this.alcohol = pAlcohol;
		this.medicaciones = pMedicaciones;
		this.enfermedades = pEnfermedades;
		this.limitacionesFisicas = pLimitacionesFisicas;
		this.operaciones = pOperaciones;
		this.actvidadesFisicas = pActividadesFisicas;
       
   }
}