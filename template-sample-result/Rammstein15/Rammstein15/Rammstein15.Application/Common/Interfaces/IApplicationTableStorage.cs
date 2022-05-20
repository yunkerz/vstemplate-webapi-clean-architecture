using Rammstein15.Application.Features.Customer.Queries;
using Rammstein15.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rammstein15.Application.Common.Interfaces
{
    public interface IApplicationTableStorage
    {
        Task<Customer> GetCustomerByCustomerId(GetCustomerByCustomerIdQuery request);
    }
}