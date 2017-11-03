using System;
using System.Collections.Generic;
using System.Text;

namespace AutoMapper.Attribute.Options
{
    public class MapOptionManage
    {
        public List<IMapOption> Options = new List<IMapOption>();
        public void MapOptions<TSource>(IMemberConfigurationExpression<TSource> opt)
            => Options.ForEach(o => o.Resolve(opt));

        public void AddOptions(IMapOptionResolver resolver) => Options.AddRange(resolver.Resolve());
    }
}
