using System.Collections.Generic;
using Jitter2.Dynamics;

namespace Jitter2;

public sealed partial class World
{
    public IEnumerable<Arbiter> GetArbiters()
    {
        return arbiters.Values;
    }
}