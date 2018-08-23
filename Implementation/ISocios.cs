using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GYM_Rocamora.Models;

namespace GYM_Rocamora
{
    public interface ISocios
    {
        List<Socio> getSocios();

		void guardar(Socio unSocio);
    }
}