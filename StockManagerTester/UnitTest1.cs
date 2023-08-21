using Contracts;
using Microsoft.Extensions.DependencyInjection;
using Repository;


namespace StockManagerTester
{
   public class Tester
    {
        RepositoryManager _man;
        public Tester(IRepositoryManager man)
        {
            _man = man;
        }

    }
    
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var services = new ServiceCollection();
            StockManager.Extensions.ServiceExtensions.ConfigureSqlContext(services);
            StockManager.Extensions.ServiceExtensions.ConfigureRepositoryManager(services);
            
          
        }
    }
}