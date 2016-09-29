using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using LayeredApp.Domain.Server.Core.Database;
using LayeredApp.Domain.Server.Core.Utilities;
using LayeredApp.Domain.Server.Core;
using LayeredApp.Domain.Server.Business.Service;
using LayeredApp.Domain.Server.Business;
using LayeredApp.Domain.Server.Business.Validation;
using LayeredApp.Domain.Server.Host;
using LayeredApp.Server.Core.Database;
using LayeredApp.Server.Core.Utilities;
using LayeredApp.Server.Core;
using LayeredApp.Server.Business.Service;
using LayeredApp.Server.Business.Validation;
using LayeredApp.Server.Business;
using LayeredApp.Server.Host;

namespace LayeredApp.Server.WebApi
{
    public class Startup
    {
        private IDatabaseLayer _databaseLayer = null;
        private IUtilitiesLayer _utilitiesLayer = null;
        private ICoreLayer _coreLayer = null;
        private IServiceLayer _serviceLayer = null;
        private IValidationLayer _validationLayer = null;
        private IBusinessLayer _businessLayer = null;
        private IHostLayer _hostLayer = null;

        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddMvc();

            var connectionString = @"Server=.\SQLEXPRESS;Database=LayeredApp;Trusted_Connection=True;";

            //var serviceProvider = services.BuildServiceProvider();

            //_databaseLayer = serviceProvider.GetService<IDatabaseLayer>();
            //_utilitiesLayer = serviceProvider.GetService<IUtilitiesLayer>();
            //_coreLayer = serviceProvider.GetService<ICoreLayer>();
            //_serviceLayer = serviceProvider.GetService<IServiceLayer>();
            //_validationLayer = serviceProvider.GetService<IValidationLayer>();
            //_businessLayer = serviceProvider.GetService<IBusinessLayer>();
            //_hostLayer = serviceProvider.GetService<IHostLayer>();

            _databaseLayer = new DatabaseLayer(connectionString);
            _utilitiesLayer = new UtilitiesLayer();
            _coreLayer = new CoreLayer(_databaseLayer, _utilitiesLayer);
            _serviceLayer = new ServiceLayer(_coreLayer);
            _validationLayer = new ValidationLayer(_coreLayer);
            _businessLayer = new BusinessLayer(_coreLayer, _serviceLayer, _validationLayer);
            _hostLayer = new HostLayer(_businessLayer);

            //services.AddScoped<IHostLayer, HostLayer>();

            services.Add(new ServiceDescriptor(typeof(IDatabaseLayer), x => _databaseLayer, ServiceLifetime.Scoped));
            services.Add(new ServiceDescriptor(typeof(IUtilitiesLayer), x => _utilitiesLayer, ServiceLifetime.Scoped));
            services.Add(new ServiceDescriptor(typeof(ICoreLayer), x => _coreLayer, ServiceLifetime.Scoped));
            services.Add(new ServiceDescriptor(typeof(IServiceLayer), x => _serviceLayer, ServiceLifetime.Scoped));
            services.Add(new ServiceDescriptor(typeof(IValidationLayer), x => _validationLayer, ServiceLifetime.Scoped));
            services.Add(new ServiceDescriptor(typeof(IBusinessLayer), x => _businessLayer, ServiceLifetime.Scoped));
            services.Add(new ServiceDescriptor(typeof(IHostLayer), x => _hostLayer, ServiceLifetime.Scoped));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            app.UseMvc();
        }
    }
}
