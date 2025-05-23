using ArchUnitNET.Domain;
using ArchUnitNET.Fluent;
using ArchUnitNET.Fluent.Slices;
using ArchUnitNET.Loader;
using ArchUnitNET.xUnit;
using Xunit;
using static ArchUnitNET.Fluent.ArchRuleDefinition;

namespace ArchUnitNETTests.ArchitectureTests
{
    public class ArchUnitArchitectureTests
    {
        private static readonly string DomainNamespace = typeof(Architecture).Namespace;
        private static readonly string LoaderNamespace = typeof(ArchLoader).Namespace;
        private static readonly string FluentNamespace = typeof(IArchRule).Namespace;

        private readonly Architecture _architecture = new ArchLoader()
            .LoadAssembly(typeof(Architecture).Assembly)
            .Build();

        [Fact]
        public void DomainHasNoDependencyOnFluent()
        {
            Types()
                .That()
                .ResideInNamespace(DomainNamespace)
                .Should()
                .NotDependOnAny(FluentNamespace)
                .Check(_architecture);
        }

        [Fact]
        public void DomainHasNoDependencyOnLoader()
        {
            Types()
                .That()
                .ResideInNamespace(DomainNamespace)
                .Should()
                .NotDependOnAny(LoaderNamespace)
                .Check(_architecture);
        }

        [Fact]
        public void LoaderHasNoDependencyOnFluent()
        {
            Types()
                .That()
                .ResideInNamespace(LoaderNamespace)
                .Should()
                .NotDependOnAny(FluentNamespace)
                .Check(_architecture);
        }

        [Fact]
        public void FluentHasNoDependencyOnLoader()
        {
            Types()
                .That()
                .ResideInNamespace(FluentNamespace)
                .Should()
                .NotDependOnAny(LoaderNamespace)
                .Check(_architecture);
        }
    }
}
