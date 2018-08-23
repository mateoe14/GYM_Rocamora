using System;
using System.Collections.Generic;

namespace GYM_Rocamora.Implementation
{
	public class ImplCuotas : ICuotas
    {
		private List<Cuota> cuotas;
        
        public ImplCuotas()
        {
			this.cuotas = new List<Cuota>();
        }

		public List<Cuota> getCuotas(){
			return cuotas;
		}
    }
}
