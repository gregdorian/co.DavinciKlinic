
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
            FacturaVenta modelVenta = new();


            modelVenta.IdCliente = entity.IdCliente;
            modelVenta.NumeroFactura = entity.NumeroFactura;
            modelVenta.SubTotal = entity.SubTotal;
            modelVenta.Impuesto = entity.Impuesto;
            modelVenta.Total = entity.Total;
            modelVenta.FechaFactura = entity.FechaFactura;


            if (entity.Equals(entity.Id))
            {
                throw new Exception("El FacturaVenta ya existe.");
            }

            ItemFactura detalle = new();

            foreach (var Item in entity.ItemFacturas)
            {
                detalle.IdFacturaVenta = Item.IdFacturaVenta;
                detalle.IdProducto = Item.IdProducto;
                detalle.CodigoProducto = Item.CodigoProducto;
                detalle.NombreProducto = Item.NombreProducto;
                detalle.Descuento = Item.Descuento;
                detalle.Cantidad = Item.Cantidad;
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
