using GreeterService.Business;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace GreeterService.Controllers
{
    [ApiController]
    [Route("api")]
    public class GreeterServiceController : ControllerBase
    {
        private readonly ILogger<GreeterServiceController> _logger;

        public GreeterServiceController(ILogger<GreeterServiceController> logger)
        {
            _logger = logger;
        }

        private GreeterImplementation innerGreeter = new GreeterImplementation();

        [HttpGet("SayHello")]
        public HelloReply SayHello(HelloRequest request)
        {
            return innerGreeter.SayHello(request);
        }
    }
}