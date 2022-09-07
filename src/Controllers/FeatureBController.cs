using Microsoft.AspNetCore.Mvc;
using Microsoft.FeatureManagement;
using Microsoft.FeatureManagement.Mvc;

namespace TestFeatureFlags.Controllers
{
    public class FeatureBController : Controller
    {
        private readonly IFeatureManager _featureManager;

        public FeatureBController(IFeatureManagerSnapshot featureManager) =>
            _featureManager = featureManager;

        [FeatureGate(MyFeatureFlags.FeatureB)]
        public IActionResult Index()
        {
            return View();
        }
    }
}
