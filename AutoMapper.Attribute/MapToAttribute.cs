using System;
using System.Collections.Generic;
using System.Text;

namespace AutoMapper.Attribute
{
    public class MapToAttribute : System.Attribute
    {
        public MapToAttribute(System.Type targetType, string targetProperty)
        {
            Type = targetType;
            Property = targetProperty;
        }

        public System.Type Type { get; set; }
        public string Property { get; set; }
        public object NullSubstitution { get; set; }
    }
}
