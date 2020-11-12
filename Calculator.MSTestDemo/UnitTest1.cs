using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace UnitTestDemo.MSTestDemo
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_ShouldCalculateNumbers()
        {
            //Arrange
            var calc = new Calculator();

            //Act
            var result = calc.Add(3, 5);

            //Assert
            Assert.IsTrue(result == 8);
        }

        [TestMethod]
        public void Get_ShouldGetCarNameBack()
        {
            //Arrange
            Mock<Car> carMock = new Mock<Car>();
            carMock.Setup(c => c.ReturnName()).Returns("Fordje");
            var factory = new Factory(carMock.Object);

            //Act
            var result = factory.GetCarName();

            //Assert
            carMock.Verify(c => c.ReturnName(),Times.Exactly(1));
            Assert.IsTrue(result == "Fordje");
        }
    }
}
