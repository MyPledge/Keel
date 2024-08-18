using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Diagnostics.Metrics;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keel
{
    public abstract class ApplicationBuilderBase : IApplicationBuilder
    {
        private readonly HostApplicationBuilder _applicationBuilder;

        public abstract IDictionary<object, object> Properties { get; }

        public IConfigurationManager Configuration => throw new NotImplementedException();

        public IHostEnvironment Environment => throw new NotImplementedException();

        public ILoggingBuilder Logging => throw new NotImplementedException();

        public IMetricsBuilder Metrics => throw new NotImplementedException();

        public IServiceCollection Services => throw new NotImplementedException();

        public ApplicationBuilderBase(ApplicationBuilderOptionsBase options)
        {
            _applicationBuilder = new(new HostApplicationBuilderSettings()
            {
                Args = options.Args,
            });
        }

        public abstract IHost Build();
        public abstract IHostBuilder ConfigureAppConfiguration(Action<HostBuilderContext, IConfigurationBuilder> configureDelegate);
        public abstract IHostBuilder ConfigureContainer<TContainerBuilder>(Action<HostBuilderContext, TContainerBuilder> configureDelegate);

        public void ConfigureContainer<TContainerBuilder>(IServiceProviderFactory<TContainerBuilder> factory, Action<TContainerBuilder>? configure = null) where TContainerBuilder : notnull
        {
            throw new NotImplementedException();
        }

        public abstract IHostBuilder ConfigureHostConfiguration(Action<IConfigurationBuilder> configureDelegate);
        public abstract IHostBuilder ConfigureServices(Action<HostBuilderContext, IServiceCollection> configureDelegate);
        public abstract IHostBuilder UseServiceProviderFactory<TContainerBuilder>(IServiceProviderFactory<TContainerBuilder> factory) where TContainerBuilder : notnull;
        public abstract IHostBuilder UseServiceProviderFactory<TContainerBuilder>(Func<HostBuilderContext, IServiceProviderFactory<TContainerBuilder>> factory) where TContainerBuilder : notnull;
    }
}
