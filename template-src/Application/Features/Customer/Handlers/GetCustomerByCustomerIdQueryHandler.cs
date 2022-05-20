using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using $safeprojectname$.Common.Interfaces;
using $safeprojectname$.Features.Customer.Queries;

using MediatR;


namespace $safeprojectname$.Features.Customer.Handlers;
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
