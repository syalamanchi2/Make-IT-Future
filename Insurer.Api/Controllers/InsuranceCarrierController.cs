using Insurer.Api.Models;
using Insurer.Models;
using Microsoft.AspNetCore.Mvc;

namespace Insurer.Api.Controllers
{
    [ApiController]
    [Route("api")]
    public class InsuranceCarrierController : ControllerBase
    {
        MIF_InsuranceAggrContext dbContext;

        public InsuranceCarrierController(MIF_InsuranceAggrContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet("getinsurersdata")]
        public InsurerData GetInsurersData()
        {
            var insurerdata = new InsurerData();

            insurerdata.Categories = dbContext.CategoryDetails.ToList();

            return insurerdata;
        }

        private void GetInsurerFeatures()
        {
            var providerFeatures = new List<ProviderFeatures>();

            var providers = dbContext.ProviderDetails.ToList();

            foreach (var item in providers)
            {
                providerFeatures.Add(
                    new ProviderFeatures()
                    {
                        ProviderId = item.ProviderId,
                        ProviderName = item.ProviderName,
                        HealthInsuranceFeatures = dbContext.HealthInsuranceFeatures.Where(item =)
                    }
            }
        }

        #region Sample
        [HttpGet("getname")]
        public string GetName()
        {
            return "Raj";
        }

        [HttpPost("postname")]
        public string PostName(Employee employee)
        {
            return employee.Name;
        }
        #endregion
    }
}
