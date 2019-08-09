using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NoticieroApi.Persistance;
using NoticieroApi.Services;

namespace NoticieroApi
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
            services.AddMvc();
            services.AddTransient<AutorService, AutorService>();
            services.AddTransient<CategoriaService, CategoriaService>();
            services.AddTransient<ComentarioService, ComentarioService>();
            services.AddTransient<NoticiaService, NoticiaService>();
            services.AddTransient<UsuarioService, UsuarioService>();

            services.AddDbContext<NoticieroDbContext>(opciones => opciones.UseSqlServer((@"data source = jenniferserver.database.windows.net,1433; initial catalog = Noticiero; user id = jenniferuser; password = Itachi-0417")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
