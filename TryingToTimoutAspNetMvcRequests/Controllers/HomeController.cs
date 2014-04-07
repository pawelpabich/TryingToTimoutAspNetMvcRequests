using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Mvc;
using TryingToTimoutAspNetMvcRequests.Models;

namespace TryingToTimoutAspNetMvcRequests.Controllers
{
    public class HomeController : Controller
    {
        [AsyncTimeoutAttribute(10000)]
        public async Task<ActionResult> Index(CancellationToken  token)
        {
            Stopwatch stopwatch = null;
            await Task.Run(async () =>
            {
                stopwatch = Stopwatch.StartNew();
                await Task.Delay(TimeSpan.FromSeconds(45), token);
                stopwatch.Stop();
            }, token);

            return View(new IndexModel() { ExecutionTime = stopwatch.Elapsed});
        }

        public async Task<ActionResult> Index2()
        {          
            return View("Index", new IndexModel() { ExecutionTime =  TimeSpan.Zero});
        }

        [HttpPost]
        [AsyncTimeoutAttribute(10000)]
        public async Task<ActionResult> Index(IndexModel model, CancellationToken token)
        {
            Stopwatch stopwatch = null;
            await Task.Run(async () =>
            {
                stopwatch = Stopwatch.StartNew();
                await Task.Delay(TimeSpan.FromSeconds(45), token);
                stopwatch.Stop();
            }, token);

            return View(new IndexModel() { ExecutionTime = stopwatch.Elapsed });
        }
    }
}