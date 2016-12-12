using Core.Interfaces;
using Infrastructure.Data;
using StructureMap.Configuration.DSL;
using StructureMap.Graph;

namespace Infrastructure {
    public class InfrastructureRegistry : Registry {
        public InfrastructureRegistry() {
            Scan(
                scan => {
                    scan.TheCallingAssembly();
                    scan.AssemblyContainingType<IGuestbookRepository>(); // Core
                    scan.WithDefaultConventions();
                });
            For<IGuestbookRepository>().Use<InMemoryGuestbookRepository>();
        }
    }
}