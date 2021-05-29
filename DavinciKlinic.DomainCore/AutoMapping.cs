using AutoMapper;
using DavinciKlinic.InfraestructureData.Modelos;

namespace DavinciKlinic.DomainCore
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<FacturaVenta, FacturaVentaDTO>();
            CreateMap<FacturaVentaDTO, FacturaVenta>();
        }
    }
}
