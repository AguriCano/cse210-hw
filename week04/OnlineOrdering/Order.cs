public class Order
{
    private Customer _customer;
    private List<Product> _products;
    private const float SHIPPING_COST_USA = 5.00f;
    private const float SHIPPING_COST_INTERNATIONAL = 35.00f;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public float CalculateTotal()
    {
        float total = 0;
        foreach (var product in _products)
        {
            total += product.GetTotalCost(); // Usa GetTotalCost() en lugar de GetPrice()
        }

        float shippingCost = _customer.IsInUSA() ? SHIPPING_COST_USA : SHIPPING_COST_INTERNATIONAL;
        total += shippingCost;

        return total;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in _products)
        {
            label += $"{product.Name} (ID: {product.ProductId})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.Name}\n{_customer.CustomerAddress.GetFullAddress()}";
    }
}
