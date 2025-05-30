using System.Collections.Generic;
using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

// Example data
var data = new Dictionary<string, List<string>>
{
    ["India"] = new List<string> { "Delhi", "Mumbai", "Bangalore" },
    ["USA"] = new List<string> { "New York", "Los Angeles", "Chicago" },
    ["France"] = new List<string> { "Paris", "Lyon", "Marseille" }
};

app.MapGet("/cities/{country}", (string country) =>
{
    var key = char.ToUpper(country[0]) + country.Substring(1).ToLower();
    if (data.ContainsKey(key))
    {
        return Results.Json(new { country = key, cities = data[key] });
    }
    else
    {
        return Results.NotFound(new { detail = "Country not found" });
    }
});

app.Run();

public partial class Program { }
