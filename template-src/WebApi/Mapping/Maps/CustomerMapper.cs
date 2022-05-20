using $ext_safeprojectname$.Domain.Entities;
using $safeprojectname$.Mapping.DTOs;

namespace $safeprojectname$.Mapping.Maps;

public static class CustomerMapper
{
    public static GetCustomerResponseDTO ToGetCustomerResponseDTO(this Customer customerReponse)
    {
        return new GetCustomerResponseDTO()
        {
            CustomerId = customerReponse.CustomerId,
            CustomerName = customerReponse.CustomerName,
            IsActive = customerReponse.IsActive
        };
    }
}
