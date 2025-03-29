// Clase Product
public class Product
{
    private string _name;
    private int _productId;
    private float _price;
    private int _quantity;

    // Constructor
    public Product(string name, int productId, float price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    // Método GetPrice (agregado para que funcione con las llamadas a GetPrice)
    public float GetPrice()
    {
        return _price;
    }

    // Método GetTotalCost
    public float GetTotalCost()
    {
        return _price * _quantity;
    }

    // Propiedades
    public string Name => _name;
    public int ProductId => _productId;
    public float Price => _price;
    public int Quantity => _quantity;
}
