using System.Linq;
using NorthwindDataAccess.Model;
using NUnit.Framework;

namespace NorthwindDataAccess.DataContext.IntegrationTests
{
    [TestFixture]
    public class ReturnsEntities
    {
        [Test]
        public void GetAll_Returns_Entities()
        {
            //given there are product entities

            //when GetAll is called on product repository
            var products = new NorthwindUnitOfWork().GetRepository<Product>().GetAll();

            //then product entities should be returned
            Assert.IsTrue(products.Any());
        }
    }
}
