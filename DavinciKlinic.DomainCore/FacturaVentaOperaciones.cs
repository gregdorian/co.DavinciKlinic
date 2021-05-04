using DavinciKlinic.InfraestructureData.Modelos;
using DavinciKlinic.InfraestructureData.Repostorios;
using System;
using System.Collections.Generic;

namespace DavinciKlinic.DomainCore
{
   public class FacturaVentaOperaciones : BaseService<FacturaVenta>, IFacturaService
    {
        private readonly IFacturaRepositorio facturasRepository;

        public FacturaVentaOperaciones(IFacturaRepositorio facturasRepository): base(facturasRepository)
        {
            this.facturasRepository = facturasRepository;
        }

        public void Insert(FacturaVenta entity)
        {


            if (entity.Equals(entity.Id))
            {
                throw new Exception("El FacturaVenta ya existe.");
            }
            facturasRepository.Insert(entity);

        }

        public void Update(FacturaVenta entity)
        {
            if (entity.Equals(entity.Id))
            {
                throw new Exception("El FacturaVenta ya existe.");
            }
            facturasRepository.Update(entity);

        }

        public void Delete(FacturaVenta entity)
        {
            facturasRepository.Delete(entity);

        }


    }
}
