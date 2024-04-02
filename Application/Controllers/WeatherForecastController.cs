using Application.Model;
using Application.Service;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

       
        private readonly IEntityService _entityService;



        public WeatherForecastController(IEntityService entityService)
        {
           
            _entityService = entityService;
        }


       
        public List<Entity> Get()
        {
            var entities = _entityService.GetEntityService();
            return entities;
        }

        
    }
}
