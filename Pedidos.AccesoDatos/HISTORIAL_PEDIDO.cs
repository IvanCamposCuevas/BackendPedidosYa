//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pedidos.AccesoDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class HISTORIAL_PEDIDO
    {
        public int id_venta { get; set; }
        public int id_detalle_venta { get; set; }
        public string rut_cliente { get; set; }
        public decimal fecha { get; set; }
        public decimal monto_total { get; set; }
    }
}
