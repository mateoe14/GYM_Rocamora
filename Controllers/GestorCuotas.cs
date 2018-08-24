using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GYM_Rocamora.Implementation;


namespace GYM_Rocamora.Controllers
{
    public class GestorCuotas : Controller
    {
		//ATRIBUTOS
        private ISocios sociosI;
        private ICuotas cuotasI;
		private IPagos pagosI;

        //CONSTRUCTOR
        public GestorCuotas()
        {

            // creamos las instancias de los objetos de acceso a datos (DAO)
            this.sociosI = new ImplSocio();
            this.cuotasI = new ImplCuotas();
            
        }

        public List<Socio> obtenerSocios()
        {

            return this.sociosI.getSocios();

        }

        public List<Cuota> obtenerCuotas()
        {

            return this.cuotasI.getCuotas();

        }

        void AltaCuota() { }
        void ModificarCuota(Socio socio) { }
        void BajaCuota(Socio socio) { }
        
        public Socio buscarSocioPorNombre(String nombre)
        {

            return this.cuotasI.buscarPorNombre(nombre);
        }
        
        public void guardarCuota(Cuota unaCuota)
        {

			cuotasI.guardar(unaCuota);

        }
    }
}
