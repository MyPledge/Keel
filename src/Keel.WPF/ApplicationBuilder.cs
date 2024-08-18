using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keel.WPF
{
    public sealed class ApplicationBuilder : ApplicationBuilderBase
    {
        public override IDictionary<object, object> Properties => throw new NotImplementedException();

        

        internal ApplicationBuilder(Type appType, string[] args) 
            : base(new ApplicationBuilderOptions() 
            { 
                AppType = appType,
                Args = args,
            })
        {
            
        }

        public override Application Build()
        {
            return default;
        }

        public override IHostBuilder ConfigureAppConfiguration(Action<HostBuilderContext, IConfigurationBuilder> configureDelegate)
        {
            throw new NotImplementedException();
        }

        public override IHostBuilder ConfigureContainer<TContainerBuilder>(Action<HostBuilderContext, TContainerBuilder> configureDelegate)
        {
            throw new NotImplementedException();
        }

        public override IHostBuilder ConfigureHostConfiguration(Action<IConfigurationBuilder> configureDelegate)
        {
            throw new NotImplementedException();
        }

        public override IHostBuilder ConfigureServices(Action<HostBuilderContext, IServiceCollection> configureDelegate)
        {
            throw new NotImplementedException();
        }

        public override IHostBuilder UseServiceProviderFactory<TContainerBuilder>(IServiceProviderFactory<TContainerBuilder> factory)
        {
            throw new NotImplementedException();
        }

        public override IHostBuilder UseServiceProviderFactory<TContainerBuilder>(Func<HostBuilderContext, IServiceProviderFactory<TContainerBuilder>> factory)
        {
            throw new NotImplementedException();
        }
    }
}
