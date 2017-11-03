using System;
using System.Collections.Generic;
using System.Text;

namespace AutoMapper.Attribute.Util
{
    public class HashCodeCombiner
    {
        public static int GetHashCode(int c1, int c2) => (c1 * 33 + c1) ^ c2;
    }
}
