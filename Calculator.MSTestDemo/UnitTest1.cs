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

        //Mocking met een concrete class. In dit geval Car_Unittest_Method_One (sorry voor de naamgeving)
        [TestMethod]
        public void Get_ShouldGetCarNameBackWithMethod()
        {
            //Arrange
            Mock<Car_Unittest_Method> carMock = new Mock<Car_Unittest_Method>();     
            carMock.Setup(c => c.ReturnName()).Returns("Fordje");
          
            
            var factory = new Factory_Unittest_Method(carMock.Object);

            //Act
            var result = factory.GetCarName();

            //Assert

            carMock.Verify(c => c.ReturnName(), Times.Exactly(1));
            Assert.IsTrue(result == "Fordje");
        }

        //Mocking met een property
        [TestMethod]
        public void Get_ShouldGetCarNameBackWithProperty()
        {
            //Arrange
            Mock<Car_Unittest_Property> carMock = new Mock<Car_Unittest_Property>();

            carMock.SetupGet(c => c.Name).Returns("Fordje");

            var factory = new Factory_Unittest_Property(carMock.Object);

            //Act
            var result = factory.GetCarName();

            //Assert

            carMock.Verify(c => c.Name, Times.Exactly(1));
            Assert.IsTrue(result == "Fordje");
        }


        //Mocking een static method
        [TestMethod]
        public void Get_ShouldGetCarNameBackWithStaticMethod()
        {
            //Arrange
            Mock<ICar> carMock = new Mock<ICar>();
            carMock.Setup(c => c.ReturnName()).Returns("Fordje");


            var factory = new Factory_Unittest_Static_Method(carMock.Object);

            //Act
            var result = factory.GetCarName();

            //Assert

            carMock.Verify(c => c.ReturnName(), Times.Exactly(1));
            Assert.IsTrue(result == "Fordje");
        }

        //Gebruik van interface wat de voorkeur verdient
        [TestMethod]
        public void Get_ShouldGetCarNameBackWithMethodWithInterface()
        {
            //Arrange
            Mock<ICar> carMock = new Mock<ICar>();
            carMock.Setup(c => c.ReturnName()).Returns("Fordje");


            var factory = new Factory_Unittest_Method_With_Interface(carMock.Object);

            //Act
            var result = factory.GetCarName();

            //Assert

            carMock.Verify(c => c.ReturnName(), Times.Exactly(1));
            Assert.IsTrue(result == "Fordje");
        }
    }
}

















