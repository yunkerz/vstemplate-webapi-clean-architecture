using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using $ext_safeprojectname$.Domain.Entities;
using $safeprojectname$.Features.Customer.Queries;

namespace $ext_safeprojectname$.Application.Common.Interfaces;
public interface IApplicationTableStorage
{
    Task<Customer> GetCustomerByCustomerId(GetCustomerByCustomerIdQuery request);
}
