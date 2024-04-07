public class Product
{
    private string name;
    private string productId;
    private double price;
    private int quantity;

    public Product(string name, string productId, double price, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }

    public double CalculateTotalCost()
    {
        return price * quantity;
    }

    public override string ToString()
    {
        return $"{name} (ID: {productId})";
    }
}