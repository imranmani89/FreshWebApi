using System;

namespace ExampleApp.WebApi;

public static class Program
{

    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        //Add Services to the controller
        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        var app = builder.Build();
        //Create Service Request Pipeline
        app.UseHttpsRedirection();
        app.Environment.EnvironmentName = "Development";
        app.UseAuthorization();
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();

        }
        System.Console.WriteLine(app.Environment.EnvironmentName.ToString());
        app.UseAuthorization();
        app.MapControllers();
        app.Run();
    }

}