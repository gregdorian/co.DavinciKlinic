using DavinciKlinic.InfraestructureData.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavinciKlinic.DomainCore
{
    public class itemVentaDTO
    {
        public int IdItemFactura { get; set; }
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
