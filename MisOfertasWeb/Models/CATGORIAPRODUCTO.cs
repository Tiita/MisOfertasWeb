//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MisOfertasWeb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CATGORIAPRODUCTO
    {
        public CATGORIAPRODUCTO()
        {
            this.PRODUCTO = new HashSet<PRODUCTO>();
        }
    
        public decimal ID_CATEGORIAPRODUCTO { get; set; }
        public string NOMBRE_CATEGORIAPROD { get; set; }
    
        public virtual ICollection<PRODUCTO> PRODUCTO { get; set; }
    }
}
