using Sample.Web.Services;
using StructureMap.Configuration.DSL;
using StructureMap.Graph;
using StructureMap.TypeRules;
using System;

namespace Sample.Web.DependencyResolution
{
    public class ParserConvention : IRegistrationConvention
    {
        public void Process(Type type, Registry registry)
        {
            if (type.CanBeCastTo<ITextParser>() && !type.IsInterface && !type.IsAbstract)
            {
                registry.AddType(typeof(ITextParser), type, type.Name);
            }
        }
    }
}