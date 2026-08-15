namespace Bombolero.Core.Entities;

public class Ingredient
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    // decimal won't suffer from floating-point arithmetic errors as double or float would, it's safer
    public decimal QuantityInStock { get; set; }
    public string UnitOfMeasurement { get; set; } = string.Empty; 
    
    public DateTime LastUpdated { get; set; }
}