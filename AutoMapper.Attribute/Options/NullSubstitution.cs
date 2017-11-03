using System;
using System.Collections.Generic;
using System.Text;

namespace AutoMapper.Attribute.Options
{
    public class NullSubstitution : IMapOption
    {
        public NullSubstitution(object nullSubsitution)
        {
            NullSubsitution = nullSubsitution;
        }
        public object NullSubsitution { get; set; }
        public void Resolve<TSource>(IMemberConfigurationExpression<TSource> opt)
                => opt.NullSubstitute(NullSubsitution);
    }
}
