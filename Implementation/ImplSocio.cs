using System;
using System.Collections.Generic;

namespace GYM_Rocamora.Implementation
{
	public class ImplSocio : ISocios
    {
		private List<Socio> socios;

        public ImplSocio()
        {
			this.socios = new List<Socio>();
			this.socios.Add(new Socio(36248674, "Mateo", "Elizalde", new DateTime(1992,08,21), "Eva Peron 468", 431804, "mateoelizalde14@gmail.com"));
        }

		public List<Socio> getSocios(){
			return socios;
		}

		public Socio buscarPorNombre (String nombre){
    
			//Se define el iterador
            Iterator<Socio> iter = socios.iterator();
            //Se declara la variable donde se almacena el resultado
            Socio encontrada = null;
            //Se recorre la lista
            while (iter.hasNext()){
                Socio actual = iter.next();
                if (actual.getNombre().equalsIgnoreCase(nombre)){
                encontrada = actual;
                break;
                }
            }
            return encontrada;
        }  

		public void guardar(Socio unSocio)
        {
            this.socios.Add(unSocio);
        }

    }
}
