using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.FileProviders;
using System;
using System.Text.Encodings.Web;
using System.Text.Json;
using static System.Net.WebRequestMethods;
var builder = WebApplication.CreateBuilder();
var app = builder.Build();

app.Run(async(context) =>
    {
        context.Response.ContentType = "text/html; charset=utf-8";
        
        await context.Response.SendFileAsync("wwwroot\\index.html");
    });
app.Run();

