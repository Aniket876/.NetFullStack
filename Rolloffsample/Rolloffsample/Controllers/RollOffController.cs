using Microsoft.AspNetCore.Mvc;
using Rolloffsample.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rolloffsample.Controllers
{
    public class RollOffController : Controller
    {
        private readonly IRollOffService _service;

        public RollOffController(IRollOffService service)
        {
            _service = service ?? throw new ArgumentNullException(nameof(service));
        }

        public async Task<IActionResult>Index()
        {
            var products = await _service.Find();
            return View(products);
        }

        public async Task<IActionResult> Search(double ggid)
        {
            var employee = await _service.SearchbyGGid(ggid);
            return View(employee);
        }
    }
}
