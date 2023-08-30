using Contracts;
using Microsoft.Extensions.DependencyInjection;
using Repository;


namespace StockManagerTester
{
    
    public class Tester
    {
        private readonly IRepositoryManager _repositoryManager;
     
        public Tester(IRepositoryManager man, IRepositoryManager repositoryManager)
        {

            _repositoryManager = repositoryManager;
            var result = _repositoryManager.InventoryRepository.GetPartTransactions(1, false);

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