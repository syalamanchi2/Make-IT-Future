using System;
using System.Collections.Generic;

namespace Insurer.Api.Models
{
    public partial class HealthInsuranceFeature
    {
        public int HealthPlanId { get; set; }
        public int? ProviderId { get; set; }
        public int? CategoryId { get; set; }
        public string? Premium { get; set; }
        public string? Cover { get; set; }
        public string? ClaimSettlementRatio { get; set; }
        public string? ExistingIllnessCovered { get; set; }
        public string? FreeHealthCheckup { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
