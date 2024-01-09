namespace ExercSecao9.Entities;

public class OrderItem
{
    public int Quantity { get; set; }
    public double Price { get; set; }

    public Product Product { get; set; }

    public OrderItem(int quantity, double price, Product product)
    {
        this.Quantity = quantity;
        this.Price = price;
        Product = product;
    }

    public double SubTotal()
    {
        return Price * Quantity;
    }

    public override string ToString()
    {
        return Product.Name + ", $" + Price.ToString("F2") + ", Quantity: " + Quantity + ", Subtotal: " +
               SubTotal().ToString("F2");
    }
}