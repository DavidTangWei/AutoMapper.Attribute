using System;
using System.Collections.Generic;
using System.Text;

namespace AutoMapper.Attribute.Options
{
    public class PropertyMapOption : IMapOption
    {
        public PropertyMapOption(string sourceName)
        {
            SourceName = sourceName;
        }
        public string SourceName { get; set; }
        public void Resolve<TSource>(IMemberConfigurationExpression<TSource> opt)
            => opt.MapFrom(src => src.GetType().GetProperty(SourceName).GetValue(src, null));
    }
}
