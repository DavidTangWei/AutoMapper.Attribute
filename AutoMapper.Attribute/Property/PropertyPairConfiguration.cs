using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Reflection;
using AutoMapper.Attribute.Options;

namespace AutoMapper.Attribute.Property
{
    public class PropertyPairConfiguration
    {
        private PropertyPairConfiguration() { }
        public static readonly PropertyPairConfiguration Instance = new PropertyPairConfiguration();
        private Dictionary<System.Type, IEnumerable<PropertyPair>> _cache = new Dictionary<System.Type, IEnumerable<PropertyPair>>();
        public IEnumerable<PropertyPair> ResolvePropertyPairs(System.Type sourceType)
        {
            if (!_cache.ContainsKey(sourceType))
            {
                var pis = sourceType.GetProperties(BindingFlags.Instance | BindingFlags.Public);
                _cache[sourceType] = pis.ToList().SelectMany(pi =>
                {
                    var attrs = pi.GetCustomAttributes(typeof(MapToAttribute), false).OfType<MapToAttribute>();
                    var pps = new List<PropertyPair>();
                    attrs.ToList().ForEach(attr =>
                    {
                        var dpi = attr.Type.GetProperty(attr.Property);
                        var mr = new MapperAttributeResolver(attr, pi.Name);
                        var pp = new PropertyPair(pi, dpi);
                        pp.OptionManage.AddOptions(mr);
                        pps.Add(pp);
                    });
                    return pps;
                });
            }
            return _cache[sourceType];
        }
    }
}
