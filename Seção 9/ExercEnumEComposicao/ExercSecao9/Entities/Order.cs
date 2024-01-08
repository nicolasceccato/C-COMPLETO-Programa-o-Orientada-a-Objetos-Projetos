namespace ExercSecao9.Entities.Enums;

public class Order
{
    public DateTime Moment { get; set; }
    public OrderStatus Status { get; set; }

    public Client Client { get; set; }
    public List<OrderItem> items { get; set; } = new List<OrderItem>();

    public Order(OrderStatus status, Client client)
    {
        Status = status;
        Client = client;
        Moment = DateTime.Now;
    }

    public void AddItem(OrderItem item)
    {
        items.Add(item);
    }

    public void RemoveItem(OrderItem item)
    {
        items.Remove(item);
    }

    public double Total()
    {
        double value = 0;

        foreach (OrderItem item in items)
        {
            value += item.SubTotal();
        }

        return value;
    }
}