using AutoMapper;
using CountryStateCity.Application.CountryStateCity.country;
using CountryStateCity.Domain.Interface;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryStateCity.Application.CountryStateCity.state.Queries.GetStates
{
    public class GetStatesQueryHandler : IRequestHandler<GetStatesQuery, List<StateVM>>
    {
        private readonly IStateRepository stateRepository;
        private readonly IMapper mapper;

        public GetStatesQueryHandler(IStateRepository stateRepository,IMapper mapper) 
        {
            this.stateRepository = stateRepository;
            this.mapper = mapper;
        }
        public async Task<List<StateVM>> Handle(GetStatesQuery request, CancellationToken cancellationToken)
        {
            var States = await stateRepository.GetAllAsync();
            var StateList = mapper.Map<List<StateVM>>(States);
            return StateList;
        }
    }
}
