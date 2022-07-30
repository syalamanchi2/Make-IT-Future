using System;
using System.Collections.Generic;

namespace Insurer.Api.Models
{
    public partial class ProviderDetail
    {
        public int ProviderId { get; set; }
        public string? ProviderName { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
