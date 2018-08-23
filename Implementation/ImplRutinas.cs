using System;
using System.Collections.Generic;

namespace GYM_Rocamora.Implementation
{
	public class ImplRutinas : IRutinas
    {
        private List<Rutina> rutinas;
        
		public ImplRutinas()
        {
		    this.rutinas = new List<Rutina>();
        }

		public List<Rutina> getRutinas()
        {
            return rutinas;
        }
    }
    
}
