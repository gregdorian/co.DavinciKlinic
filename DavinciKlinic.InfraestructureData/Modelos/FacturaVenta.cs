using DavinciKlinic.InfraestructureData.SeedWork;
using System;
using System.Collections.Generic;

#nullable disable

namespace DavinciKlinic.InfraestructureData.Modelos
{
    public partial class FacturaVenta : Entidad
    {


        public int? IdCliente { get; set; }
        public string NumeroFactura { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? Impuesto { get; set; }
        public decimal? Total { get; set; }
        public DateTime? FechaFactura { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; }
        public virtual List<ItemFactura> ItemFacturas { get; set; }
    }
}
