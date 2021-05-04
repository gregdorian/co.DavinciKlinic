using DavinciKlinic.InfraestructureData.SeedWork;
using System;
using System.Collections.Generic;

#nullable disable

namespace DavinciKlinic.InfraestructureData.Modelos
{
    public partial class ItemFactura : Entidad
    {

        public int? IdFacturaVenta { get; set; }
        public int? IdProducto { get; set; }
        public string CodigoProducto { get; set; }
        public string NombreProducto { get; set; }
        public decimal? Descuento { get; set; }
        public short? Cantidad { get; set; }

        public virtual FacturaVenta IdFacturaVentaNavigation { get; set; }
        public virtual Producto IdProductoNavigation { get; set; }
    }
}
