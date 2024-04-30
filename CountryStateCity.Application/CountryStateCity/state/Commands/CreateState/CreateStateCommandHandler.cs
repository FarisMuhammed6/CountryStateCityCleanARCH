using AutoMapper;
using CountryStateCity.Domain.Entities;
using CountryStateCity.Domain.Interface;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryStateCity.Application.CountryStateCity.state.Commands.CreateState
{
    public class CreateStateCommandHandler : IRequestHandler<CreateStateCommand, StateVM>
    {
        private readonly IStateRepository stateRepository;
        private readonly IMapper mapper;

        public CreateStateCommandHandler(IStateRepository stateRepository,IMapper mapper)
        {
            this.stateRepository = stateRepository;
            this.mapper = mapper;
        }
        public async Task<StateVM> Handle(CreateStateCommand request, CancellationToken cancellationToken)
        {
            var stateentity = new State
            {
                Name = request.Name,
                CountryId = request.CountryId
            };
            var result = await stateRepository.CreateAsync(stateentity);
            return mapper.Map<StateVM>(result);
        }
    }
}
