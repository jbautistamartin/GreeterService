using Grpc.Core;
using GreeterService;
using Microsoft.AspNetCore.Mvc;
using GreeterService.Business;

namespace GreeterService.Services
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public class GreeterService : Greeter.GreeterBase
    {
        private readonly ILogger<GreeterService> _logger;

        public GreeterService(ILogger<GreeterService> logger)
        {
            _logger = logger;
        }

        private GreeterImplementation innerGreeter = new GreeterImplementation();

        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            return Task.FromResult(innerGreeter.SayHello(request));
        }
    }
}