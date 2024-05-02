using CountryStateCity.Application.CountryStateCity.country.Commands.CreateCountry;
using CountryStateCity.Application.CountryStateCity.country.Commands.DeleteCountry;
using CountryStateCity.Application.CountryStateCity.country.Commands.UpdateCountry;
using CountryStateCity.Application.CountryStateCity.country.Queries.GetCountries;
using CountryStateCity.Application.CountryStateCity.country.Queries.GetCountryById;
using CountryStateCity.Application.CountryStateCity.state.Commands.CreateState;
using CountryStateCity.Application.CountryStateCity.state.Commands.DeleteState;
using CountryStateCity.Application.CountryStateCity.state.Commands.UpdateState;
using CountryStateCity.Application.CountryStateCity.state.Queries.GetStateById;
using CountryStateCity.Application.CountryStateCity.state.Queries.GetStates;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CountryStateCity.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StateController : ControllerBase
    {
        private readonly IMediator mediator;

        public StateController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> CreateState(CreateStateCommand command)
        {

            var createState = await mediator.Send(command);
            return CreatedAtAction(nameof(GetById), new { id = createState.Id }, createState);
        }
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById(int Id)
        {
            var state = await mediator.Send(new GetStateByIdQuery() { StateId = Id });
            if (state == null)
            {
                return NotFound();
            }
            return Ok(state);
        }
        [HttpGet]
        public async Task<IActionResult> GetAllASYNC()
        {

            var states = await mediator.Send(new GetStatesQuery());

            return Ok(states);
        }
        [HttpPut("{Id}")]
        public async Task<IActionResult> UpdateState(int Id, UpdateStateCommand command)
        {
            if (Id != command.Id)
            {
                return BadRequest();
            }
            await mediator.Send(command);
            return NoContent();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteState(int id, DeleteStateCommand command)
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
