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
    
    public partial class OFERTA
    {
        public OFERTA()
        {
            this.PRODUCTO1 = new HashSet<PRODUCTO>();
            this.VALORACION = new HashSet<VALORACION>();
        }
    
        public decimal ID_OFERTA { get; set; }
        public decimal MAXIMO_PRO { get; set; }
        public decimal MINIMO_PRO { get; set; }
        public System.DateTime FECHA_LIMITE { get; set; }
        public System.DateTime FECHA_REGISTRO { get; set; }
        public decimal PORCENTAJE_DESCUENTO { get; set; }
        public decimal PRODUCTO_ID_PRODUCTO { get; set; }
    
        public virtual PRODUCTO PRODUCTO { get; set; }
        public virtual ICollection<PRODUCTO> PRODUCTO1 { get; set; }
        public virtual ICollection<VALORACION> VALORACION { get; set; }
    }
}
