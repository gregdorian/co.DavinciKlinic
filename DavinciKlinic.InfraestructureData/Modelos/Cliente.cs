using DavinciKlinic.InfraestructureData.SeedWork;
using System;
using System.Collections.Generic;

#nullable disable

namespace DavinciKlinic.InfraestructureData.Modelos
{
    public partial class Cliente : Entidad
    {
 
        public string CodigoCliente { get; set; }
        public string NombreCliente { get; set; }
        public int Edad { get; set; }
        public string DireccionCliente { get; set; }
        public string TelefonoCliente { get; set; }
        public string DescripcionCliente { get; set; }
        public DateTime? FechaIngreso { get; set; }

        public virtual List<FacturaVenta> FacturaVenta { get; set; }
    }
}
