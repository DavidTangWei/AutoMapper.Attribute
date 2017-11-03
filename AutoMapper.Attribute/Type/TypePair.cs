using AutoMapper.Attribute.Property;
using AutoMapper.Attribute.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoMapper.Attribute.Type
{
    public class TypePair : IEquatable<TypePair>
    {
        public TypePair(System.Type source, System.Type destination)
        {
            Source = source;
            Destination = destination;
        }
        public PropertyPairCollection PropertyPairs { get; set; }
            = new PropertyPairCollection();
        public System.Type Source { get; set; }
        public System.Type Destination { get; set; }
        public bool Equals(TypePair other) => Source == other.Source && Destination == other.Destination;
        public override bool Equals(object obj) => obj is TypePair && Equals((TypePair)obj);
        public override int GetHashCode() => HashCodeCombiner.GetHashCode(Source.GetHashCode(), Destination.GetHashCode());
    }
}
