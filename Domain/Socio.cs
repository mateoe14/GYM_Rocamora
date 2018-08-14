public class Socio
{
  //ATRIBUTOS
  private int dni {get; set;};
  private String nombre {get; set;};
  private String apellido {get; set;};
  private Date fechaNac {get; set;};
  private String domicilio {get; set;};
  private int telefono {get; set;};
  private String mail {get; set;};
  private List<FichaMedica> fichaMedica {get; set;};
  private List<Cuota> cuotas {get; set;};
  private List<Rutina> rutinas {get; set;};

//CONSTRUCTORES
  public Socio(){}

  public Socio(int pDni, String pNombre, String pApellido, Date pFechaNac, String pDomicilio, int pTelefono, String pMail){
      this.dni = pDni;
      this.nombre = pNombre;
      this.apellido = pApellido;
      this.fechaNac = pFechaNac;
      this.domicilio = pDomicilio;
      this.telefono = pTelefono;
      this.mail = pMail;
    }

//PROPIEDADES
/*public void setDni(int pDni){
    this.dni = pDni;
}*/
}