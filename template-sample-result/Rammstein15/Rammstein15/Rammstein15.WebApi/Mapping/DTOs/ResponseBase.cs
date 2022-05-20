using Newtonsoft.Json;

namespace Rammstein15.WebApi.Mapping.DTOs
{
    public class ResponseBase
    {
        [JsonProperty("hasError")]
        public bool HasError { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("errorDetail")]
        public string ErrorDetail { get; set; }
    }
}