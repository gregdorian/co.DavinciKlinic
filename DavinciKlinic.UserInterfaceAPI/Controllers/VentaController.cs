using DavinciKlinic.DomainCore;
using DavinciKlinic.InfraestructureData.Modelos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using AutoMapper;

namespace DavinciKlinic.UserInterfaceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaController : ControllerBase
    {
        //*** la inyeccion de dependencias para realizar un proyecto sencillo
        private readonly IFacturaService facturaOps;
        private readonly IMapper _mapper;

        public VentaController(IFacturaService facturaOps, IMapper mapper)
        {
            this.facturaOps = facturaOps;
            _mapper = mapper;
        }
        [HttpPost]
        public IActionResult Add(FacturaVentaDTO venta)
        {
            try
            {
                FacturaVenta modelVenta = new();
                var facturaVenta = _mapper.Map<FacturaVenta>(venta);
                facturaOps.Add(facturaVenta);
          
            }
            catch (Exception ex)
            {

                //throw = ex.Message;
            }

            return Ok();
        }
    }
}
