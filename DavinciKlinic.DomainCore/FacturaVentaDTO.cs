using DavinciKlinic.InfraestructureData.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavinciKlinic.DomainCore
{
   public class FacturaVentaDTO
    {

        public int IdFacturaVenta { get; set; }
        public int IdCliente { get; set; }
        public string NumeroFactura { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Impuesto { get; set; }
        public decimal Total { get; set; }
        public DateTime? FechaFactura { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; }
        public virtual ICollection<ItemFactura> ItemFacturas { get; set; }

        public FacturaVentaDTO()
        {
            this.ItemFacturas = new List<ItemFactura>();
        }
    }
}
