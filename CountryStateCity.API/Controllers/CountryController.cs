using CountryStateCity.Application.CountryStateCity.country.Commands.CreateCountry;
using CountryStateCity.Application.CountryStateCity.country.Commands.DeleteCountry;
using CountryStateCity.Application.CountryStateCity.country.Commands.UpdateCountry;
using CountryStateCity.Application.CountryStateCity.country.Queries.GetCountries;
using CountryStateCity.Application.CountryStateCity.country.Queries.GetCountryById;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CountryStateCity.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly IMediator mediator;

        public CountryController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> CreateCountry(CreateCountryCommand command)
        {
            
            var createBlog = await mediator.Send(command);
            return CreatedAtAction(nameof(GetById), new { id = createBlog.Id }, createBlog);
        }
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById(int Id)
        {
            var country = await mediator.Send(new GetCountryByIdQuery() { CountryId = Id });
            if (country == null)
            {
                return NotFound();
            }
            return Ok(country);
        }
        [HttpGet]
        public async Task<IActionResult> GetAllASYNC()
        {
            
            var blogs = await mediator.Send(new GetCountriesQuery());
           
            return Ok(blogs);
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
