using DavinciKlinic.InfraestructureData.SeedWork;
using System;
using System.Collections.Generic;

#nullable disable

namespace DavinciKlinic.InfraestructureData.Modelos
{
    public partial class Producto : Entidad
    {
        public string CodigoProducto { get; set; }
        public string NombreProducto { get; set; }
        public decimal? PrecioUnitario { get; set; }
        public decimal? PrecioCosto { get; set; }
        public short? Stock { get; set; }
        public short? StockMinimo { get; set; }
        public DateTime? FechaIngreso { get; set; }

        public virtual List<ItemFactura> ItemFacturas { get; set; }
    }
}
