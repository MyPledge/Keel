using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keel
{
    public abstract class ApplicationBase : IApplication
    {
        public abstract IServiceProvider Services { get; }

        public abstract void Dispose();
        public abstract Task StartAsync(CancellationToken cancellationToken = default);
        public abstract Task StopAsync(CancellationToken cancellationToken = default);
    }
}
