using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SoapCore;

var builder = WebApplication.CreateBuilder(args);

// Agregar los servicios de SoapCore
builder.Services.AddSoapCore();
builder.Services.AddScoped<IHelloService, HelloService>();

var app = builder.Build();

// Configurar SoapCore correctamente
app.UseRouting();

// Usamos 'UseSoapEndpoint' en 'IApplicationBuilder'
app.UseSoapEndpoint<IHelloService>("/HelloService.svc", new SoapEncoderOptions());

app.Run();

// Definición del servicio SOAP
public interface IHelloService
{
    string SayHello();
}

public class HelloService : IHelloService
{
    public string SayHello() => "Hola Mundo";
}

