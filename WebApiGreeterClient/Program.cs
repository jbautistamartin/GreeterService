using Newtonsoft.Json;
using WebApiGreeterClient.ServideGreeterClientServiceReference;

//Establecer un certificado que no es de confianza
var httpHandler = new HttpClientHandler();
httpHandler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;
var httpClient = new HttpClient(httpHandler);

// The port number must match the port of the gRPC server.
var client = new GreeterClient("https://localhost:5105", httpClient);

// LLamo al servicio
var reply = await client.SayHelloAsync(new HelloRequest { Name = "GreeterClient" });
Console.WriteLine("WebApi Greeting: " + reply.Message);

Console.WriteLine("Press any key to exit...");
Console.ReadKey();