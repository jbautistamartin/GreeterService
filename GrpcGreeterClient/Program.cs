﻿using Grpc.Net.Client;
using GrpcGreeterClient;

//Establecer un certificado que no es de confianza
var httpHandler = new HttpClientHandler();
httpHandler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;

//The port number must match the port of the gRPC server.
var channel = GrpcChannel.ForAddress("https://localhost:5104", new GrpcChannelOptions { HttpHandler = httpHandler });
var client = new Greeter.GreeterClient(channel);

var reply = await client.SayHelloAsync(new HelloRequest { Name = "GreeterClient" });
Console.WriteLine("GRPC Greeting: " + reply.Message);

Console.WriteLine("Press any key to exit...");
Console.ReadKey();