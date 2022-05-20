using Newtonsoft.Json;

namespace Rammstein15.WebApi.Mapping.DTOs
{
    public class GetCustomerResponseDTO : ResponseBase
    {
        [JsonProperty("customerId")]
        public string CustomerId { get; set; }

        [JsonProperty("customerName")]
        public string CustomerName { get; set; }

        [JsonProperty("isActive")]
        public bool? IsActive { get; set; }
    }
}