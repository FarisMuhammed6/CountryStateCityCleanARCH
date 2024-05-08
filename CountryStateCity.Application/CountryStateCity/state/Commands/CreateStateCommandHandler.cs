using AutoMapper;
using CountryStateCity.Domain.Entities;
using CountryStateCity.Domain.Interface;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryStateCity.Application.CountryStateCity.state.Commands
{
    public class CreateStateCommandHandler : IRequestHandler<CreateStateCommand, StateDTO>
    {
        private readonly IRepository repository;
        private readonly IMapper mapper;

        public CreateStateCommandHandler(IRepository repository,IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public async Task<StateDTO> Handle(CreateStateCommand request, CancellationToken cancellationToken)
        {
            var stateentity = new State
            {
                Name = request.Name,
                CountryId = request.CountryId
            };
            var result = await repository.CreateStateAsync(stateentity);
            return mapper.Map<StateDTO>(result);
        }
    }
}
