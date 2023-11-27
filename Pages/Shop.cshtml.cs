using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Sibyllium.Pages;
public class ShopModel : PageModel
{
    public Dictionary<Product, int> products = new Dictionary<Product, int>{
    {Product.GetProduct("Sussy Kette"), 10},
    {Product.GetProduct("Stein"), 2},
    {Product.GetProduct("Heil Stock"), 12},
    {Product.GetProduct("Heilige Klangschale"), 4},
    {Product.GetProduct("Mondbox"), 54},
    {Product.GetProduct("Chakra Kette"),32},
};
    private readonly ILogger<IndexModel> _logger;

    public ShopModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}