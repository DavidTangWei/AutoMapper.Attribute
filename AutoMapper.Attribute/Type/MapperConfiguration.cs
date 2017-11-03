using AutoMapper.Attribute.Property;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AutoMapper.Attribute.Type
{
    public class MapperConfiguration
    {
        private MapperConfiguration() { }
        public static readonly MapperConfiguration Instance = new MapperConfiguration();

        private List<TypePair> Mappers { get; set; } = new List<TypePair>();
        public void Resolve(IEnumerable<PropertyPair> pps)
        {
            if (pps == null)
                throw new ArgumentNullException(nameof(pps));
            pps.ToList().ForEach(pp =>
            {
                var tp = pp.GetTypePair();
                if (!Mappers.Contains(tp))
                    Mappers.Add(tp);
                var stp = Mappers.First(m => m.Equals(tp));
                stp.PropertyPairs.AddOrUpdate(pp);
            });
        }

        public TypePair GetTypePair<TSource, TDestination>()
            => Mappers.FirstOrDefault(p => p.Destination == typeof(TDestination) && p.Source == typeof(TSource));
    }
}
