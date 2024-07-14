using Microsoft.AspNetCore.Mvc;
using System;

namespace Using_SQL_Data_Sources.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReportController : ControllerBase
    {
        private readonly ILogger<DataController> _logger;

        public ReportController(ILogger<DataController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get(string name)
        {
            var reportPath = $"Reports\\{name}.mrt";
            var bytes = System.IO.File.ReadAllBytes(reportPath);
            return new FileContentResult(bytes, "application/xml");
        }
    }
}