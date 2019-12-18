using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Faza.Treasury.Facade.Mappers
{
    class AutoMapperConfig
    {
        public static MapperConfiguration GetConfig()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.AllowNullCollections = true;
                cfg.AllowNullDestinationValues = true;

                var types = Assembly.GetAssembly(typeof(AutoMapperConfig)).GetTypes().Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(Profile)));
                foreach (Type type in types)
                {
                    cfg.AddProfile(type);
                }

                cfg.ForAllMaps((typeMap, mappingExpression) =>
                {
                    mappingExpression.MaxDepth(0);
                    mappingExpression.IgnoreAllNonExisting(typeMap.SourceType, typeMap.DestinationType);
                });
            });
        }
    }
}
