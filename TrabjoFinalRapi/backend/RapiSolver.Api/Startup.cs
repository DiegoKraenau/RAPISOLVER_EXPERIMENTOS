using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using RapiSolver.Repository;
using RapiSolver.Repository.context;
using RapiSolver.Repository.implementation;
using RapiSolver.Service;
using RapiSolver.Service.implementation;
using Swashbuckle.AspNetCore.Swagger;
using Microsoft.OpenApi.Models;
using System.Reflection;
using System.IO;

namespace RapiSolver.Api
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
            services.AddEntityFrameworkNpgsql ().AddDbContext<ApplicationDbContext> (opt =>
                opt.UseNpgsql (Configuration.GetConnectionString ("DefaultConnection"))); 

            services.AddTransient<IClienteRepository, ClienteRepository> ();
            services.AddTransient<IClienteService, ClienteService> ();

            services.AddTransient<IRolRepository, RolRepository> ();
            services.AddTransient<IRolService, RolService> ();

            services.AddTransient<IUsuarioRepository, UsuarioRepository> ();
            services.AddTransient<IUsuarioService, UsuarioService> ();

            services.AddTransient<ICustomerRepository, CustomerRepository> ();
            services.AddTransient<ICustomerService, CustomerService> ();

            services.AddTransient<ISupplierRepository, SupplierRepository> ();
            services.AddTransient<ISupplierService, SupplierService> ();

            services.AddTransient<ILocationRepository, LocationRepository> ();
            services.AddTransient<ILocationService, LocationService> ();

            services.AddTransient<IServiceCategoryRepository, ServiceCategoryRepository> ();
            services.AddTransient<IServiceCategoryService, ServiceCategoryService> ();

            services.AddTransient<IServicioRepository, ServicioRepository> ();
            services.AddTransient<IServicioService, ServicioService> ();

            services.AddTransient<IServiceDetailsRepository, ServiceDetailsRepository> ();
            services.AddTransient<IServiceDetailsService, ServiceDetailsService> ();

            services.AddTransient<IRecommendationRepository, RecommendationRepository> ();
            services.AddTransient<IRecommendationService, RecommendationService> ();

            services.AddTransient<IReservationRepository, ReservationRepository> ();
            services.AddTransient<IReservationService, ReservationService> ();


             services.AddCors (options => {
                options.AddPolicy ("Todos",
                    builder => builder.WithOrigins ("*").WithHeaders ("*").WithMethods ("*"));
            });


            services.AddControllers();


            /*services.AddSwaggerGen(swagger =>
            {
                var contact = new Contact() { Name = SwaggerConfiguration.ContactName };
                swagger.SwaggerDoc(SwaggerConfiguration.DocNameV1,
                                    new Info
                                    {
                                        Title = SwaggerConfiguration.DocInfoTitle,
                                        Version = SwaggerConfiguration.DocInfoVersion,
                                        Description = SwaggerConfiguration.DocInfoDescription,
                                        Contact = contact
                                    }
                                    );
            });*/

            services.AddSwaggerGen(c =>
            {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
            // Set the comments path for the Swagger JSON and UI.
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });

           
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors ("Todos");

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint(SwaggerConfiguration.EndpointUrl, SwaggerConfiguration.EndpointDescription);
            });

            
            //app.UseHttpsRedirection();
            
        }
    }
}
