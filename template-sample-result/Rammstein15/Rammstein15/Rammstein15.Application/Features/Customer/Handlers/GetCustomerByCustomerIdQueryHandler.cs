using MediatR;
using Rammstein15.Application.Common.Interfaces;
using Rammstein15.Application.Features.Customer.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Rammstein15.Application.Features.Customer.Handlers
{
    public class GetCustomerByCustomerIdQueryHandler : IRequestHandler<GetCustomerByCustomerIdQuery, Domain.Entities.Customer>
    {
        private readonly IApplicationTableStorage _applicationTableStorage;

        public GetCustomerByCustomerIdQueryHandler(IApplicationTableStorage applicationTableStorage)
        {
            _applicationTableStorage = applicationTableStorage;
        }

        public async Task<Domain.Entities.Customer> Handle(GetCustomerByCustomerIdQuery request, CancellationToken cancellationToken)
        {
            return await _applicationTableStorage.GetCustomerByCustomerId(request);
        }

    }
}