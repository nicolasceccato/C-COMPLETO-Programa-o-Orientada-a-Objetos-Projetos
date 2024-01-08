namespace ExercSecao9.Entities;

public class OrderItem
{
    public int quantity { get; set; }
    public double price { get; set; }

    public Product Product { get; set; }

    public OrderItem(int quantity, double price)
    {
        this.quantity = quantity;
        this.price = price;
    }

    public double SubTotal()
    {
        return price * quantity;
    }
}