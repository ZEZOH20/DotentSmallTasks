using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace DotnetTranning.src.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoutesController : ControllerBase
    {
        private readonly EndpointDataSource _endpointDataSource;

        public RoutesController(EndpointDataSource endpointDataSource)
        {
            _endpointDataSource = endpointDataSource;
        }

        [HttpGet("list")]
        public IActionResult ListAllRoutes()
        {
            var routes = _endpointDataSource.Endpoints
                .OfType<RouteEndpoint>()
                .Select(e => new
                {
                    RouteTemplate = e.RoutePattern.RawText,
                    Method = e.Metadata.OfType<HttpMethodMetadata>().FirstOrDefault()?.HttpMethods.FirstOrDefault() ?? "N/A"
                })
                .ToList();

            return Ok(routes);
        }
    }
}

