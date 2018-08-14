public class FichaMedica
{
   //ATRIBUTOS
   private Date fechaEntrega;
   private Float peso;
   private Float altura;
   private String grupoSanguineo;
   private Boolean hipertensionArterial;
   private Boolean diabetes;
   private Boolean afeccionCardioVascular;
   private Boolean afeccionRespiratoria;
   private Boolean fuma;
   private Boolean alcohol;
   private List<Medicacion> medicaciones;
   private List<Enfermedad> enfermedades;
   private List<LimitacionFisica> limitacionesFisica;
   private List<Operacion> operaciones;
   private List<ActividadFisica> actvidadesFisicas;

   //CONSTRUCTORES
   public FichaMedica(){}

   public FichaMedica(Date fechaEntrega, Float peso, String grupoSanguineo, Boolean hipertensionArterial, Boolean diabetes, Boolean afeccionCardioVascular, Boolean afeccionRespiratoria, Boolean fuma, Boolean alcohol)
   {
       
   }
}