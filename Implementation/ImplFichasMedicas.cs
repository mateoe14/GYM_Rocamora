using System;
using System.Collections.Generic;

namespace GYM_Rocamora.Implementation
{
	public class ImplFichasMedicas : IFichasMedicas
    {
		private List<FichaMedica> fichasMedicas;

		public ImplFichasMedicas()
        {
			this.fichasMedicas = new List<FichaMedica>();
        }

		public List<FichaMedica> getFichasMedicas()
        {
			return fichasMedicas;
        }
    }
}
