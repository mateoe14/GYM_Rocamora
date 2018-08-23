using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GYM_Rocamora.Implementation;

namespace GYM_Rocamora
{
    /// <summary>
    /// permite gestionar la solicitud de prestamo si es valida
    /// dependiendo si cumple con los criterios de los evaluadores definidos
    /// para cada tipo de cliente
    /// </summary>
    public class GestorSocios
    {
	
		//ATRIBUTOS
	    private ISocios sociosI;
        private ICuotas cuotasI;
        private IRutinas rutinasI;
        private IFichasMedicas fichasMedicasI;
    
        //CONSTRUCTOR
        public GestorSocios(){

			// creamos las instancias de los objetos de acceso a datos (DAO)
			this.sociosI = new ImplSocio();
			this.cuotasI = new ImplCuotas();
            this.rutinasI = new ImplRutinas();
			this.fichasMedicasI = new ImplFichasMedicas();
              
        }
    
		public List<Socio> obtenerSocios()
        {

			return this.sociosI.getSocios();

        }

		public List<Cuota> obtenerCuotas(){
    
			return this.cuotasI.getCuotas();
        
        }
    
        public List<Rutina> obtenerRutinas(){
    
            return this.rutinasI.getRutinas();
    
        }
    
        public List<FichaMedica> obtenerFichasMedicas(){
    
			return this.fichasMedicasI.getFichasMedicas();
    
        }

		void AltaSocio(){}
		void ModificarSocio(Socio socio){}
		void BajaSocio(Socio socio){}
        
        /*public Socio buscarSocioPorNombre(String nombre){
       
            return this.sociosI.buscarPorNombre(nombre);
        }*/
    
        public void guardarSocio(Socio unSocio){
    
			sociosI.guardar(unSocio);
        
        }
    
        //Para la Tabla de Personajes Agregados vamos a necesitar lo siguiente
        /*public List<Actor> obtenerActores(){
    
        return this.actoresDAO.getActores();
        }
    
        public List<Rol> obtenerRoles(){
    
            return this.rolesDAO.getRoles();
        }
    
        public List<Personaje> obtenerPersonajes(){
    
            return this.personajesDAO.getPersonajes();
        }
        
        public void guardarPersonaje (Personaje unPersonaje){
    
            this.personajesDAO.guardar(unPersonaje);      
        }*/
    }
}