using Bombolero.Infrastructure.Data;
using Bombolero.Core.Entities;

namespace Bombolero.Api.Features.Ingredients;

public static class CreateIngredient
{
    // The request DTO
    public record Request(string Name, decimal QuantityInStock, string UnitOfMeasurement);

    public static void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapPost("/api/ingredients", HandleAsync)
            .WithTags("Ingredients");
    }

    public static async Task<IResult> HandleAsync(Request request, BomboleroDbContext dbContext)
    {
        var ingredient = new Ingredient
        {
            Name = request.Name,
            QuantityInStock = request.QuantityInStock,
            UnitOfMeasurement = request.UnitOfMeasurement,
            LastUpdated = DateTime.UtcNow
        };

        dbContext.Ingredients.Add(ingredient);
        
        await dbContext.SaveChangesAsync();
        
        return Results.Created($"/api/ingredients/{ingredient.Id}", ingredient);
    }
}