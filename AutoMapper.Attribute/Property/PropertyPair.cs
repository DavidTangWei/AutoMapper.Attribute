using AutoMapper.Attribute.Options;
using AutoMapper.Attribute.Type;
using AutoMapper.Attribute.Util;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace AutoMapper.Attribute.Property
{
    public class PropertyPair : IEquatable<PropertyPair>
    {
        public MapOptionManage OptionManage { get; } = new MapOptionManage();
        public PropertyPair(PropertyInfo source, PropertyInfo destination)
        {
            Source = source;
            Destination = destination;
        }
        public TypePair GetTypePair() => new TypePair(Source.DeclaringType, Destination.DeclaringType);
        public PropertyInfo Source { get; set; }
        public PropertyInfo Destination { get; set; }
        public bool Equals(PropertyPair other) => Source == other.Source && Destination == other.Destination;
        public override int GetHashCode() => HashCodeCombiner.GetHashCode(Source.GetHashCode(), Destination.GetHashCode());

        public void MapOptions<TSource>(IMemberConfigurationExpression<TSource> opt) => OptionManage.MapOptions(opt);
    }
}
