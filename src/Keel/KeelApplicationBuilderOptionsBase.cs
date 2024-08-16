using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keel
{
    public abstract class KeelApplicationBuilderOptionsBase : IKeelApplicationBuilderOptionsBase
    {
        public required string[] Args { get; init; }
    }
}
