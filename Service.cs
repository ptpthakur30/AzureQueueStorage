namespace QueueStorage
{
    using System.Collections.Generic;
using System.Text.Json.Serialization;

    public class ServiceCommonProps
    {
        [JsonPropertyName("domain_name")]
        public string DomainName { get; set; }

        [JsonPropertyName("service_name")]
        public string ServiceName { get; set; }
    }

    public class Service : ServiceCommonProps
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("service_details")]
        public List<ServiceDetails> ServiceDetails { get; set; }
    }


    public class ServiceDetails
    {
        [JsonPropertyName("region")]
        public string Region { get; set; }

        [JsonPropertyName("dependent_services")]
        public DependentServices[] DependentServices { get; set; }

        [JsonPropertyName("version")]
        public string Version { get; set; }

        [JsonPropertyName("health_status")]
        public string HealthStatus { get; set; }

        [JsonPropertyName("health_endpoint")]
        public string HealthEndpoint { get; set; }

    }

    public class DependentServices : ServiceCommonProps
    {
        [JsonPropertyName("version")]
        public string Version { get; set; }

        [JsonPropertyName("service_details")]
        public ServiceDetails ServiceDetails { get; set; }
    }
}
