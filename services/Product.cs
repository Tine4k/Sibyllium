using System.Text.Json;

namespace Sibyllium;
public record Product{
    public Product(float Price, string? Name, string? Description, string? ImagePath)
    {
        this.Price = Price;
        this.Name = Name ?? "Product not found :(";
        this.Description = Description ?? "This product is so mysterious that even we don't know exactly what its powers are!";
        this.ImagePath = ImagePath ?? "FileNotFound.jpg";
    }
    public static Product GetProduct(string Name)
    {
        try
        {
            return JsonSerializer.Deserialize<Product>(File.ReadAllText($"products/{Name}.json")) ?? new Product(0,null,null,null);;   
        }
        catch (System.Exception)
        {
            return new Product(0,null,null,null);
        }
    }
    public float Price {get; init;}
    public string Name {get; init;}
    public string Description {get; init;} 
    public string ImagePath {get; init;}
}