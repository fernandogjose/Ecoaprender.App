using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ecoaprender.app.di;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace ecoaprender.app.webapi {
    public class Startup {
        public Startup (IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices (IServiceCollection services) {
            services.AddCors ();
            services.AddMvc ();

            Bootstrap.Configure (services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure (IApplicationBuilder app, IHostingEnvironment env) {
            if (env.IsDevelopment ()) {
                app.UseDeveloperExceptionPage ();
            }

            app.UseCors (options => options
                .AllowAnyHeader ()
                .WithMethods ("GET", "POST", "PUT", "DELETE")
                .WithOrigins ("http://localhost:8100")
            );

            // app.UseCors (options => options
            //     .AllowAnyHeader ()
            //     .AllowAnyMethod ()
            //     .AllowAnyOrigin ());

            app.UseMvc ();
        }
    }
}