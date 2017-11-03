using System;
using System.Collections.Generic;
using System.Text;

namespace AutoMapper.Attribute.Options
{
    public class MapperAttributeResolver : IMapOptionResolver
    {
        public MapperAttributeResolver(MapToAttribute data, string sourceName)
        {
            Data = data;
            SourceName = sourceName;
        }
        public string SourceName { get; set; }
        public MapToAttribute Data { get; set; }
        public IEnumerable<IMapOption> Resolve()
        {
            IList<IMapOption> mos = new List<IMapOption>();
            if (!string.IsNullOrEmpty(SourceName))
                mos.Add(new PropertyMapOption(SourceName));
            if (Data.NullSubstitution != null)
                mos.Add(new NullSubstitution(Data.NullSubstitution));
            return mos;
        }
    }
}
