using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Keel.WPF
{
    public sealed class KeelWpfApplication : KeelApplicationBase
    {
        public override IServiceProvider Services => throw new NotImplementedException();

        public override void Dispose()
        {
            
            throw new NotImplementedException();
        }

        public override Task StartAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public override Task StopAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public static KeelWpfApplicationBuilder CreateBuilder<T>(string[] args)
            where T : Application
        {
            return new(typeof(T), args);
        }

        public static KeelWpfApplicationBuilder CreateBuilder(Type appType, string[] args)
        {
            return new(appType, args);
        }
    }
}
