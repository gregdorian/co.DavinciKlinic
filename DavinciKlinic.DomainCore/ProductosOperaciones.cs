using DavinciKlinic.InfraestructureData.Modelos;
using DavinciKlinic.InfraestructureData.Repostorios;
using System;
using System.Collections.Generic;

namespace DavinciKlinic.DomainCore
{
    public class ProductosOperaciones : BaseService<Producto>, IProductosService
    {
        private readonly IProductosRepositorio productosRepository;

        public ProductosOperaciones(IProductosRepositorio productoRepository) : base(productoRepository)
        {
            this.productosRepository = productoRepository;
        }


    }
}
