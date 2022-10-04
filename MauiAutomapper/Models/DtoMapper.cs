using System;
using System.Reflection;
using AutoMapper;
using AutoMapper.Internal;

namespace MauiAutomapper.Models
{
    public static class DtoMapper
    {
        private static IMapper _autoMapper;

        internal static void Initialize()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AllowNullCollections = true;
                var assembly = typeof(DtoMapper).GetTypeInfo().Assembly;
                cfg.AddMaps(assembly);
            });
            _autoMapper = config.CreateMapper();
        }

        public static T Map<T>(object obj)
        {
            return _autoMapper.Map<T>(obj);
        }
    }
}

