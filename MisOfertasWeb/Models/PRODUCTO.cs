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
    
    public partial class PRODUCTO
    {
        public decimal ID_PRODUCTO { get; set; }
        public string NOMBRE_PRODUCTO { get; set; }
        public decimal PRECIO_PRODUCTO { get; set; }
        public decimal STOCK_PRODUCTO { get; set; }
        public string DESCRIPCION_PRODUCTO { get; set; }
        public byte[] IMAGEN_PRODUCTO { get; set; }
        public decimal RUBROPRODUCTO_ID_RUBRO { get; set; }
        public decimal MARCA_ID_MARCA { get; set; }
        public decimal CATPROD_ID_CATPROD { get; set; }
        public decimal OFERTA_ID_OFERTA { get; set; }
    }
}
