using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RCLExample.Web.Configuration;

namespace RCLExample.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProxyController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly TemplatesConfiguration _config;

        public ProxyController(ILogger<WeatherForecastController> logger, TemplatesConfiguration config)
        {
            _logger = logger;
            _config = config;
        }

        [HttpGet]
        public IActionResult Get([FromQuery] string template)
        {
            _logger.LogInformation($"Called Proxy Get '{template}'");

            var route = _config.TemplateUrls.FirstOrDefault(x => x.TemplateName == template);
            if (route == null)
            {
                return NotFound();
            }
            else
            {
                return new RedirectResult(route.Url ?? "");
            }
        }
    }
}