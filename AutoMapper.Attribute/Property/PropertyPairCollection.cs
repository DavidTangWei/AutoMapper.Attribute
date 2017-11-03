using System;
using System.Collections.Generic;
using System.Text;

namespace AutoMapper.Attribute.Property
{
    public class PropertyPairCollection
    {
        public List<PropertyPair> Pairs { get; set; } = new List<PropertyPair>();
        public void AddOrUpdate(PropertyPair pp)
        {
            var index = Pairs.IndexOf(pp);
            if (index == -1)
                Pairs.Add(pp);
            else
                Pairs[index] = pp;
        }
    }
}
