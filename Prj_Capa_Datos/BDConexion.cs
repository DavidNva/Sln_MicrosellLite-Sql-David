using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_Capa_Datos
{
    public class BDConexion
    {
        public string Conectar()
        {
            return @"data source=Libero\DavidSql; Initial Catalog=POS_Microsell_Lite; Integrated Security=true";//Autentificacion con windows
            //C# no admite escribir un \ invertida, por ello se antepone un arroba antes de indicar la oracion, en este caso la consulta
            //y asi acepte dicha diagonal invertida (solo para este caso que el localhost se llama "Libero\DavidSql"
        }
    }
}
