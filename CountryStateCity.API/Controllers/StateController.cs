using CountryStateCity.Application.CountryStateCity.state.Commands;
using CountryStateCity.Application.CountryStateCity.state.Commands.DeleteState;
using CountryStateCity.Application.CountryStateCity.state.Commands.UpdateState;
using CountryStateCity.Domain.Interface.Queries.Maters;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CountryStateCity.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StateController : ControllerBase
    {
        private readonly IStateQueries stateQueries;
        private readonly IMediator mediator;

        public StateController(IStateQueries stateQueries, IMediator mediator)
        {
            this.stateQueries = stateQueries;
            this.mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> CreateState(CreateStateCommand command)
        {

            var createState = await mediator.Send(command);
            return CreatedAtAction(nameof(GetById), new { id = createState.Id }, createState);
        }
        [HttpGet("{Id}")]
        public IActionResult GetById(int Id)
        {
            var state = stateQueries.GetStateById(Id);
            if (state == null)
            {
                return NotFound();
            }
            return Ok(state);
        }
        [HttpGet]
        public IActionResult GetAllASYNC()
        {

            var states = stateQueries.GetAll();

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
