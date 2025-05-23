using System.Collections.Generic;
using ArchUnitNET.Domain;
using Xunit;

namespace ArchUnitNETTests.Domain
{
    public class ArchitectureCacheTests
    {
        private readonly TestArchitectureCache _testArchitectureCache;
        private readonly ArchitectureCacheKey _testArchitectureCacheKey;
        private readonly Architecture _testEmptyArchitecture;

        public ArchitectureCacheTests()
        {
            _testArchitectureCache = new TestArchitectureCache();

            _testArchitectureCacheKey = new ArchitectureCacheKey();
            _testArchitectureCacheKey.Add(typeof(ArchitectureCacheTests).Assembly.FullName, null);

            _testEmptyArchitecture = new Architecture(
                new List<Assembly>(),
                new List<Namespace>(),
                new List<IType>(),
                new List<GenericParameter>(),
                new List<IType>()
            );
        }

        [Fact]
        public void DuplicateArchitectureDetected()
        {
            _testArchitectureCache.Add(_testArchitectureCacheKey, _testEmptyArchitecture);
            _testArchitectureCache.Add(_testArchitectureCacheKey, _testEmptyArchitecture);

            Assert.True(_testArchitectureCache.Size() == 1);
        }

        [Fact]
        public void GetExistingArchitecture()
        {
            _testArchitectureCache.Add(_testArchitectureCacheKey, _testEmptyArchitecture);
            Assert.Equal(
                _testArchitectureCache.TryGetArchitecture(_testArchitectureCacheKey),
                _testEmptyArchitecture
            );
        }

        [Fact]
        public void CacheClear()
        {
            _testArchitectureCache.Add(_testArchitectureCacheKey, _testEmptyArchitecture);
            Assert.Equal(
                _testArchitectureCache.TryGetArchitecture(_testArchitectureCacheKey),
                _testEmptyArchitecture
            );
            _testArchitectureCache.Clear();
            Assert.Null(_testArchitectureCache.TryGetArchitecture(_testArchitectureCacheKey));
        }
    }
}
