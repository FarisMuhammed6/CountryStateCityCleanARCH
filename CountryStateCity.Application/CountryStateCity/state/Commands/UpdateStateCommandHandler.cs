﻿using CountryStateCity.Application.CountryStateCity.country.Commands.UpdateCountry;
using CountryStateCity.Domain.Entities;
using CountryStateCity.Domain.Interface;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryStateCity.Application.CountryStateCity.state.Commands.UpdateState
{
    public class UpdateStateCommandHandler : IRequestHandler<UpdateStateCommand,int>
    {
        private readonly IRepository repository;

        public UpdateStateCommandHandler(IRepository repository)
        {
            this.repository = repository;
        }
        public async Task<int> Handle(UpdateStateCommand request, CancellationToken cancellationToken)
        {
            var updateentity = new State
            {
                Name = request.Name,
                CountryId = request.CountryId
            };
            return await repository.UpdateStateAsync(request.Id, updateentity);
        }
    }
}
