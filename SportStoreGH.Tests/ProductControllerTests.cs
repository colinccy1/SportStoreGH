using System.Collections.Generic;
using System.Linq;
using Moq;
using SportStoreGH.Controllers;
using SportStoreGH.Models;
using Xunit;

namespace SportStoreGH.Tests
{
    public class ProductControllerTests
    {
        [Fact]
        public void Can_Paginate()
        {
            //Arrange
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup(m=>m.Products).Returns(new Product[]{
                new Product { ProductID = 1, Name = "P1" },
                new Product { ProductID = 2, Name = "P2" },
                new Product { ProductID = 3, Name = "P3" },
                new Product { ProductID = 4, Name = "P4" },
                new Product { ProductID = 5, Name = "P5" }
            });

            ProductController controller = new ProductController(mock.Object);
            controller.PageSize = 3;

            //act
            IEnumerable<Product> result = controller.List(2).ViewData.Model as IEnumerable<Product>;

            //assert
            Product[] proArray = result.ToArray();
            Assert.True(proArray.Length == 2);
            Assert.Equal("P4", proArray[0].Name);
            Assert.Equal("P5", proArray[1].Name);
        }
    }
}
