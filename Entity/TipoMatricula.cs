using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Entity
{
    public class TipoMatricula
    {
        public decimal id_tipomatricula { get; set; }
        public string descripcion_tipomatricula { get; set; }

        MatriculaEntities db = new MatriculaEntities();
        public List<TipoMatricula> ReadAll()
        {
            return db.TIPOMATRICULAs.Select(c => new TipoMatricula()
            {
                id_tipomatricula = c.ID_TIPOMATRICULA,
                descripcion_tipomatricula = c.DESCRIPCION_TIPOMATRICULA
            }).ToList();
        }
    }
}
