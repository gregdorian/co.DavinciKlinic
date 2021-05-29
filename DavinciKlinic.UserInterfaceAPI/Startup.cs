using DavinciKlinic.DomainCore;
using DavinciKlinic.InfraestructureData.Modelos;
using DavinciKlinic.InfraestructureData.Repostorios;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace DavinciKlinic.UserInterfaceAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DavinciKlinicDBContext>(options =>
        options.UseSqlServer(
            Configuration.GetConnectionString("DavinciKlinicConn")));
            services.AddControllers();
            //automaper
            services.AddAutoMapper(typeof(Startup));
            //Servicios de la capa de aplicación con servicios de dominio
            services.AddScoped(typeof(IBaseService<>), typeof(BaseService<>));
            services.AddScoped<IClientesService, ClientesOperaciones>();
            services.AddScoped<IFacturaService, FacturaVentaOperaciones>();
            services.AddScoped<IProductosService, ProductosOperaciones>();

            //Repositorio del dominio a los de infraestructura
            services.AddScoped(typeof(IRepositorioBase<>), typeof(RepositorioBase<>));
            services.AddScoped<IClientesRepositorio, ClientesRepository>();
            services.AddScoped<IFacturaRepositorio, FacturaRepository>();
            services.AddScoped<IProductosRepositorio, ProductoRepository>();

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
