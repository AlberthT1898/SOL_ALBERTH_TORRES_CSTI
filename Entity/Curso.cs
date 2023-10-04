using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Entity
{
    public class Curso
    {
        public decimal id_curso { get; set; }
        public string descripcion_curso { get; set; }
        public int cantidadcreditos_curso { get; set; }


        Data.MatriculaEntities db = new Data.MatriculaEntities();
        public List<Curso> ReadAll()
        {
            return db.CURSOes.Select(c => new Curso()
            {
                id_curso = c.ID_CURSO,
                descripcion_curso = c.DESCRIPCION_CURSO
            }).ToList();
        }
    }
}
