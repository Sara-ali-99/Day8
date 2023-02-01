using Microsoft.AspNetCore.Mvc;
using Day8.ServiceLifeTime;
namespace Day8.Controllers
{
    public class ServiceLifetimeController : Controller
    {
        private readonly ISingletonService singletonService;
        private readonly ItransiantService itransiantService;
        private readonly IScopedService scopedService;

        public ServiceLifetimeController(ISingletonService singletonService,
            ItransiantService itransiantService, IScopedService scopedService)
        {
            this.singletonService = singletonService;
            this.itransiantService = itransiantService;
            this.scopedService = scopedService;
        }
        public IActionResult Index()
        {
            ViewBag.singleton = singletonService.Message;
            ViewBag.transiant = itransiantService.Message;
            ViewBag.scoped = scopedService.Message;
            return View();
        }
    }
}
