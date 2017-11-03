using AutoMapper.Attribute.Property;
using AutoMapper.Attribute.Type;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoMapper.Attribute
{
    public class MapResolver
    {
        public static IMappingExpression<TSource, TDestination> Map<TSource, TDestination>(IProfileExpression profile)
        {
            MapperConfiguration.Instance.Resolve(PropertyPairConfiguration.Instance.ResolvePropertyPairs(typeof(TSource)));
            var tp = MapperConfiguration.Instance.GetTypePair<TSource, TDestination>();
            var me = profile.CreateMap<TSource, TDestination>();
            tp.PropertyPairs.Pairs.ForEach(pp => me.ForMember(pp.Destination.Name, opt => pp.MapOptions(opt)));
            return me;
        }
    }
}
