//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class TIPOMATRICULA
    {
        public TIPOMATRICULA()
        {
            this.MATRICULAs = new HashSet<MATRICULA>();
        }
    
        public decimal ID_TIPOMATRICULA { get; set; }
        public string DESCRIPCION_TIPOMATRICULA { get; set; }
    
        public virtual ICollection<MATRICULA> MATRICULAs { get; set; }
    }
}
