using Rammstein15.Domain.Entities;
using Rammstein15.WebApi.Mapping.DTOs;

namespace Rammstein15.WebApi.Mapping.Maps
{
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
}