using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Vacante
    {
        public int id_vacante { get; set; }
        public int id_seccion { get; set; }
        public int id_curso { get; set; }
        public int numero_vacantes { get; set; }

        public Seccion seccion { get; set; }
        public Curso curso { get; set; }

    }
}
