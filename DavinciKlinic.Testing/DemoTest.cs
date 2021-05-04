using DavinciKlinic.DomainCore;
using DavinciKlinic.InfraestructureData.Modelos;
using DavinciKlinic.UserInterfaceAPI.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace DavinciKlinic.Testing
{
    public class DemoTest
    {
        private readonly IClientesService clientesOps;

        [Fact]
        public void Test1()
        {
            Assert.True(1 == 1);

        }

        [Fact]
        public void ClienteIntegrationTest()
        {
            //Crear DB
            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            var optionsBuilder = new DbContextOptionsBuilder<DavinciKlinicDBContext>();
            optionsBuilder.UseSqlServer(configuration["ConnectionStrings:DavinciKlinicConn"]);

            var context = new DavinciKlinicDBContext(optionsBuilder.Options);

            //Realizar Borrado de Todos Loc clientes Existentes en la BD
            context.Clientes.RemoveRange(context.Clientes.ToArray());
            context.SaveChanges();

            //Crear Controllador
            ClientesController controller = new ClientesController(clientesOps);

                //Adicionar un Cliente
                controller.AddCliente(new Cliente()
                {
                    CodigoCliente = "09HZ",
                    NombreCliente = "Paten Huglin",
                    Edad = 20,
                    DireccionCliente = "48512 Ridgeway Point",
                    TelefonoCliente = "647 8987",
                    DescripcionCliente = "Greece",
                    FechaIngreso = DateTime.Now,
                    FacturaVenta = null,
                    Id = 1,
                    FechaRegistro = DateTime.Now,
                    Eliminado = false
                 });

        //Chequear: que el Metodo GetAll Retorne el Cliente adicionado
        var result = (controller.GetCliente ()).ToArray();

         Assert.Single(result);
        Assert.Equal("09HZ", result[0].CodigoCliente);
       }
    }
}
