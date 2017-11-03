using System;
using System.Collections.Generic;
using System.Text;

namespace AutoMapper.Attribute.Options
{
    public interface IMapOption
    {
        void Resolve<TSource>(IMemberConfigurationExpression<TSource> opt);
    }
}
