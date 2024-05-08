using CountryStateCity.Application.CountryStateCity.city.Commands;
using CountryStateCity.Domain.Interface.Queries.Maters;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CountryStateCity.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly ICityQueries cityQueries;
        private readonly IMediator mediator;

        public CityController(ICityQueries cityQueries, IMediator mediator)
        {
            this.cityQueries = cityQueries;
            this.mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> CreateCity(CreateCityCommand command)
        {

            var createCity = await mediator.Send(command);
            return CreatedAtAction(nameof(GetById), new { id = createCity.Id }, createCity);
        }
        [HttpGet("{Id}")]
        public IActionResult GetById(int Id)
        {
            var city = cityQueries.GetCityById(Id);
            if (city == null)
            {
                return NotFound();
            }
            return Ok(city);
            /* try
              {
                  return Ok(city);
              }
              catch (Exception ex)
              {
                  return BadRequest(ex.Message);
              }*/
        }
        [HttpGet]
        public IActionResult GetAllASYNC()
        {

            var cities = cityQueries.GetAll();
            return Ok(cities);
        }
        [HttpPut("{Id}")]
        public async Task<IActionResult> UpdateCity(int Id, UpdateCityCommand command)
        {
            if (Id != command.Id)
            {
                return BadRequest();
            }
            await mediator.Send(command);
            return NoContent();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteCity(int id, DeleteCityCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }
            await mediator.Send(command);
            return NoContent();

            // var reultt = await mediator.Send(new DeleteCityCommand { Id = id}); //Dont want dive deletecitycommand if this applied
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {

            var cities = cityQueries.GetAll();
            return Ok(cities);
        }
    }
}
