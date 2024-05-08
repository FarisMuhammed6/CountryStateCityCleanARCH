using CountryStateCity.Domain.Interface;
using MediatR;

namespace CountryStateCity.Application.CountryStateCity.state.Commands.DeleteState
{
    public class DeleteStateCommandHandler : IRequestHandler<DeleteStateCommand, int>
    {
        private readonly IRepository repository;

        public DeleteStateCommandHandler(IRepository repository)
        {
            this.repository = repository;
        }
        public async Task<int> Handle(DeleteStateCommand request, CancellationToken cancellationToken)
        {
            return await repository.DeleteStateByIdAsync(request.Id);
        }
    }
}
