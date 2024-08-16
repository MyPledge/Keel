using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keel.WPF
{
    internal class KeelWpfApplicationBuilderOptions : KeelApplicationBuilderOptionsBase
    {
        public required Type AppType { get; init; }
    }
}