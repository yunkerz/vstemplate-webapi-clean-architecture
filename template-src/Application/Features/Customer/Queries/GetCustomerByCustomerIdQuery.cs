using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MediatR;

namespace $safeprojectname$.Features.Customer.Queries;
public class GetCustomerByCustomerIdQuery : IRequest<Domain.Entities.Customer>
{
    public string RequestingUserId { get; set; }

    public string CustomerId { get; set; }
}
