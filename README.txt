dotnet dev-certs https -ep GreeterService.pfx -p GreeterService


docker build -t greeterservice -f Dockerfile .

--> Para contenedores Windows.

docker create --name greeterservice -p 5104:5104 -p 5105:5105 -e ASPNETCORE_Kestrel__Certificates__Default__Password=GreeterService -e ASPNETCORE_Kestrel__Certificates__Default__Path=C:\App\GreeterService.pfx --user ContainerAdministrator greeterservice

--> Para contenedores Linux.

docker create --name greeterservice -p 5001:5001 -p 5105:5105 -e ASPNETCORE_Kestrel__Certificates__Default__Password=GreeterService -e ASPNETCORE_Kestrel__Certificates__Default__Path=/App/GreeterService.pfx greeterservice
