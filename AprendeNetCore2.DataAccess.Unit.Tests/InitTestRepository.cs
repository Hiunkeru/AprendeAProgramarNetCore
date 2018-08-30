using AprendeNetCore2.DataAccess.Repository;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace AprendeNetCore2.DataAccess.Unit.Tests
{
    [TestClass]
    public class InitTestRepository
    {

        [AssemblyInitialize()]
        public static void Setup(TestContext context)
        {
            AddDataContext.PrepareContext();
        }

    }
}
