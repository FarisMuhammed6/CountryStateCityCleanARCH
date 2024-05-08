using CountryStateCity.Application.CountryStateCity.country.Commands;
using CountryStateCity.Application.CountryStateCity.country.Commands.DeleteCountry;
using CountryStateCity.Application.CountryStateCity.country.Commands.UpdateCountry;
using CountryStateCity.Domain.Interface.Queries.Maters;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CountryStateCity.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ICountryQueries countryQueries;
        private readonly IMediator mediator;

        public CountryController(ICountryQueries countryQueries, IMediator mediator)
        {
            this.countryQueries = countryQueries;
            this.mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> CreateCountry(CreateCountryCommand command)
        {

            var createCountry = await mediator.Send(command);
            return CreatedAtAction(nameof(GetById), new { id = createCountry.Id }, createCountry);
        }
        [HttpGet("{Id}")]
        public IActionResult GetById(int Id)
        {
            var country = countryQueries.GetCountryById(Id);
            if (country == null)
            {
                return NotFound();
            }
            return Ok(country);
        }
        [HttpGet]
        public IActionResult GetAllASYNC()
        {

            var country = countryQueries.GetAll();

            return Ok(country);
        }
        [HttpPut("{Id}")]
        public async Task<IActionResult> UpdateCountry(int Id, UpdateCountryCommand command)
        {
            if (Id != command.Id)
            {
                return BadRequest();
            }
            await mediator.Send(command);
            return NoContent();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteCountry(int id, DeleteCountryCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }
            await mediator.Send(command);
            return NoContent();
        }
    }
}
