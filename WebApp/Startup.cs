﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebApp.DAO;

namespace WebApp
{
    public class Startup
    {

        private IConfiguration _configuration;


        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                          .SetBasePath(env.ContentRootPath)
                          .AddJsonFile("appsetting.json", optional: true, reloadOnChange: true)
                          .AddJsonFile("config.json", optional: true, reloadOnChange: true);

            _configuration = builder.Build();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            var sqlConnection = _configuration.GetConnectionString("MyWebAppDB");
            services.AddDbContext<MyWebAppContext>(options =>
                                                        options.UseMySql(
                                                                sqlConnection,
                                                                b => b.MigrationsAssembly("WebApp")
                                                         )
                                                  );
            // adicionando framework do ASP.NET MVC
            services.AddMvc();

            // mapeando interface... serve pra não precisar explicitar sua declaração
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseStaticFiles();
            
            // utilizar o mvc com uma rota padrão
            app.UseMvcWithDefaultRoute();
        }
    }
}
