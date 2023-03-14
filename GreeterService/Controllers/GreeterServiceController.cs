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

        [HttpGet("SayHello")]
        public HelloReply SayHello(HelloRequest request)
        {
            return new HelloReply
            {
                Message = "Hello " + request.Name
            };
        }
    }
}