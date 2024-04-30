using AutoMapper;
using CountryStateCity.Application.CountryStateCity.country;
using CountryStateCity.Domain.Interface;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryStateCity.Application.CountryStateCity.state.Queries.GetStateById
{
    public class GetStateByIdQueryHandler : IRequestHandler<GetStateByIdQuery, StateVM>
    {
        private readonly IStateRepository stateRepository;
        private readonly IMapper mapper;

        public GetStateByIdQueryHandler(IStateRepository stateRepository,IMapper mapper)
        {
            this.stateRepository = stateRepository;
            this.mapper = mapper;
        }
        public async Task<StateVM> Handle(GetStateByIdQuery request, CancellationToken cancellationToken)
        {
            var State = await stateRepository.GetByIdAsync(request.StateId);

            var StateList = mapper.Map<StateVM>(State);

            return StateList;
        }
    }
}
