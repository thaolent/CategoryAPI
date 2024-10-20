using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using CategoryAPI;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Endpoint to get hardcoded category data
app.MapGet("/categories", () =>
{
    var categories = new List<Category>
    {
        new Category { ID = 1, Name = "Vinamilk" },
        new Category { ID = 2, Name = "TH True Milk" },
        new Category { ID = 3, Name = "Nutifood" },
        new Category { ID = 4, Name = "Dalat Milk 1" }
    };

    return categories;
});

app.Run();
