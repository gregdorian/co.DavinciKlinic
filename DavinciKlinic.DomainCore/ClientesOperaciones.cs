using DavinciKlinic.InfraestructureData.Modelos;
using DavinciKlinic.InfraestructureData.Repostorios;
using System;
using System.Collections.Generic;

namespace DavinciKlinic.DomainCore
{
    public class ClientesOperaciones : BaseService<Cliente>, IClientesService
    {
    
        private readonly IClientesRepositorio clienteRepository;
        
        public ClientesOperaciones(IClientesRepositorio clienteRepository) : base(clienteRepository)
        {
            this.clienteRepository = clienteRepository;
        }



        //Colocar Metodos de Persistencia adicionales para Clientes
    }


}
