using CountryStateCity.Domain.Interface;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryStateCity.Application.CountryStateCity.state.Commands.DeleteState
{
    public class DeleteStateCommandHandler : IRequestHandler<DeleteStateCommand, int>
    {
        private readonly IStateRepository stateRepository;

        public DeleteStateCommandHandler(IStateRepository stateRepository)
        {
            this.stateRepository = stateRepository;
        }
        public async Task<int> Handle(DeleteStateCommand request, CancellationToken cancellationToken)
        {
            return await stateRepository.DeleteByIdAsync(request.Id);
        }
    }
}
