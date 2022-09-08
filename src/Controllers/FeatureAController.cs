using Microsoft.AspNetCore.Mvc;
using Microsoft.FeatureManagement;
using Microsoft.FeatureManagement.Mvc;

namespace TestFeatureFlags.Controllers
{
    public class FeatureAController : Controller
    {
        private readonly IFeatureManager _featureManager;

        public FeatureAController(IFeatureManagerSnapshot featureManager) =>
            _featureManager = featureManager;

        [FeatureGate(MyFeatureFlags.FeatureA)]
        public IActionResult Index()
        {
            return View();
        }
    }
}
