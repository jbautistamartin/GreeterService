namespace GreeterService.Business
{
    public class GreeterImplementation
    {
        public HelloReply SayHello(HelloRequest request)
        {
            return new HelloReply
            {
                Message = "Hello " + request.Name
            };
        }
    }
}