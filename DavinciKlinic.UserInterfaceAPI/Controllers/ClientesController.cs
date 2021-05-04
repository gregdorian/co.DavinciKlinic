using DavinciKlinic.DomainCore;
using DavinciKlinic.InfraestructureData.Modelos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DavinciKlinic.UserInterfaceAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        //*** la inyeccion de dependencias para realizar un proyecto sencillo
        private readonly IClientesService clientesOps;

        //**constructor para inyectar
        public ClientesController(IClientesService clientesOps)
        {
            this.clientesOps = clientesOps;
        }
        // GET: api/<ClientesController>
        [HttpGet]
        public IEnumerable<Cliente> GetCliente()
        {
            try
            {
                return clientesOps.GetAll();
            }
            catch (Exception)
            {

                throw;
            }
        }

        // GET api/<ClientesController>/5
        [HttpGet("{id}")]
        public Cliente GetIdCliente(int id)
        {
            try
            {
                return clientesOps.GetById(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        // POST api/<ClientesController>
        [HttpPost]
        public void AddCliente([FromBody] Cliente value)
        {
            try
            {
                clientesOps.Add(value);
            }
            catch (Exception)
            {

                throw;
            }
        }

        // PUT api/<ClientesController>/5
        [HttpPut("{id}")]
        public void UpdateCliente(int id, [FromBody] Cliente value)
        {
            try
            {
                var oCliente = clientesOps.GetById(id);
                if (oCliente != null)
                {

                    clientesOps.Modify(value);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        // DELETE api/<ClientesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            try
            {
                var oCliente = clientesOps.GetById(id);
                if (oCliente != null)
                {

                    clientesOps.Delete(id);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }

}
