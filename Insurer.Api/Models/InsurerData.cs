namespace Insurer.Api.Models
{
    public class InsurerData
    {
        public List<CategoryDetail> Categories { get; set; }
        public List<ProviderDetail> ProviderFeatures { get; set; }
    }

    public class ProviderFeatures
    {
        public int ProviderId { get; set; }
        public string ProviderName { get; set; }
        public HealthInsuranceFeature HealthInsuranceFeatures { get; set; }
        public CasualtynsuranceFeature CasualtyInsuranceFeatures { get; set; }
    }
}
