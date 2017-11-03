using System;
using System.Collections.Generic;
using System.Text;

namespace AutoMapper.Attribute.Options
{
    public interface IMapOptionResolver
    {
        IEnumerable<IMapOption> Resolve();
    }
}
