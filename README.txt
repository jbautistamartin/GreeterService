docker build -t grpcgreeter -f Dockerfile .

--> Para contenedores Windows.

docker create --name grpcgreeter -p 5001:5001 -e ASPNETCORE_Kestrel__Certificates__Default__Password=GrpcGreeter -e ASPNETCORE_Kestrel__Certificates__Default__Path=C:\App\GrpcGreeter.pfx --user ContainerAdministrator grpcgreeter

--> Para contenedores Linux.

docker create --name grpcgreeter -p 5001:5001 -e ASPNETCORE_Kestrel__Certificates__Default__Password=GrpcGreeter -e ASPNETCORE_Kestrel__Certificates__Default__Path=/App/GrpcGreeter.pfx grpcgreeter
