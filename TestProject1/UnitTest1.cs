using Application.Controllers;
using Application.Model;
using Application.Service;
using Moq;
using System.Collections.Generic;

namespace TestProject1
{
    public class UnitTest1
    {
        public Mock<IEntityService> mock = new Mock<IEntityService>();
        
        [Fact]
        public void Test1()
        {
            List<Entity> entityList = new List<Entity>() {
            new Entity()  { Id = 1,Name="Entity1"},
            new Entity()  { Id = 2,Name="Entity2"},
        };
            mock.Setup(p => p.GetEntityService()).Returns(entityList);
            var controller=new WeatherForecastController(mock.Object);
            var result = controller.Get();
            Assert.NotNull(result);
            Assert.Equal(entityList, result);

    }
       
        
    }
    
}