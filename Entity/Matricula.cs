using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Entity
{
    public class Matricula
    {
        public int id_matricula { get; set; }
        public int tipo_matricula { get; set; }
        public DateTime fecha_matricula { get; set; }
        public DateTime fechaanulacion_matricula { get; set; }
        public int codigo_alumno { get; set; }
        public int id_curso { get; set; }

        public Alumno alumno { get; set; }
        public Curso curso { get; set; }
        public TipoMatricula tipomatricula { get; set; }


        MatriculaEntities db = new MatriculaEntities();


        public Matricula Find(int id)
        {
            return this.db.MATRICULAs.Select(p => new Matricula()
            {
                id_curso = this.id_curso,
                tipo_matricula = this.tipo_matricula,
                fecha_matricula = this.fecha_matricula,
                fechaanulacion_matricula = this.fechaanulacion_matricula,
                codigo_alumno = this.codigo_alumno,         
            }).Where(p => p.id_curso == this.id_curso).FirstOrDefault();
        }
        public bool Save()
        {
            try
            {
                db.SP_CREATE_MATRICULA(this.tipo_matricula, this.codigo_alumno, this.id_curso);
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
