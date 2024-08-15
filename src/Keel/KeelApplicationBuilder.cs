using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keel
{
    public abstract class KeelApplicationBuilder : IHostBuilder
    {
        public abstract IDictionary<object, object> Properties { get; }

        public abstract IHost Build();
        public abstract IHostBuilder ConfigureAppConfiguration(Action<HostBuilderContext, IConfigurationBuilder> configureDelegate);
        public abstract IHostBuilder ConfigureContainer<TContainerBuilder>(Action<HostBuilderContext, TContainerBuilder> configureDelegate);
        public abstract IHostBuilder ConfigureHostConfiguration(Action<IConfigurationBuilder> configureDelegate);
        public abstract IHostBuilder ConfigureServices(Action<HostBuilderContext, IServiceCollection> configureDelegate);
        public abstract IHostBuilder UseServiceProviderFactory<TContainerBuilder>(IServiceProviderFactory<TContainerBuilder> factory) where TContainerBuilder : notnull;
        public abstract IHostBuilder UseServiceProviderFactory<TContainerBuilder>(Func<HostBuilderContext, IServiceProviderFactory<TContainerBuilder>> factory) where TContainerBuilder : notnull;
    }
}
