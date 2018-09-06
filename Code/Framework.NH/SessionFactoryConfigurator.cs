using System.Data;
using System.Reflection;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Dialect;
using NHibernate.Driver;
using NHibernate.Event;
using NHibernate.Mapping.ByCode;

namespace Framework.NH
{
    public static class SessionFactoryConfigurator
    {
        public static ISessionFactory Create(string connectionStringName, Assembly mappingAssembly)
        {
            var configuration = new Configuration();
            configuration.DataBaseIntegration(cfg =>
            {
                cfg.Dialect<MsSql2012Dialect>();
                cfg.Driver<SqlClientDriver>();
                cfg.ConnectionStringName = connectionStringName;
                cfg.IsolationLevel = IsolationLevel.ReadCommitted;
            });

            var modelMapper = new ModelMapper();
            modelMapper.AddMappings(mappingAssembly.GetExportedTypes());
            var hbmMapping = modelMapper.CompileMappingForAllExplicitlyAddedEntities();
            configuration.AddDeserializedMapping(hbmMapping,"test");

            return configuration.BuildSessionFactory();
        }
    }
}
