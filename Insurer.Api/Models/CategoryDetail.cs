using System;
using System.Collections.Generic;

namespace Insurer.Api.Models
{
    public partial class CategoryDetail
    {
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
