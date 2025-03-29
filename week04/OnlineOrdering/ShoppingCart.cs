// Class ShoppingCart
public class ShoppingCart
{
    private List<Product> _products;

    // Constructor
    public ShoppingCart()
    {
        _products = new List<Product>();
    }

    // Methods
    public void AddProduct(Product product)
    {
        _products.Add(product);
        Console.WriteLine($"Product '{product.Name}' added to the shopping cart.");
    }

    public void RemoveProduct(Product product)
    {
        _products.Remove(product);
        Console.WriteLine($"Product '{product.Name}' removed from the shopping cart.");
    }

    public void CalculateTotal()
    {
        float total = _products.Sum(product => product.GetPrice());
        Console.WriteLine($"Total amount for the cart: {total}");
    }
}