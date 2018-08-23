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

		public void guardar(Socio unSocio)
        {
            this.socios.Add(unSocio);
        }

    }
}
