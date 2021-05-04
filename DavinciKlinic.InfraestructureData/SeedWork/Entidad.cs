using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavinciKlinic.InfraestructureData.SeedWork
{
    public class Entidad
    {
        public int Id { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public bool Eliminado { get; set; }
    }
}
