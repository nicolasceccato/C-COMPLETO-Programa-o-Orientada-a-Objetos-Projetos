using System.Text;

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

    public override string ToString()
    {
        StringBuilder sB = new StringBuilder();
        sB.AppendLine("ORDER SUMMARY: ");
        sB.Append("Order moment: ");
        sB.AppendLine(this.Moment.ToString("dd/MM/yyyy HH:mm:ss"));
        sB.Append("Order status: ");
        sB.AppendLine(this.Status.ToString());
        sB.Append("Client: ");
        sB.AppendLine(Client.ToString());
        sB.AppendLine("ORDER ITEMS: ");
        foreach (OrderItem orderItem in items)
        {
            sB.AppendLine(orderItem.ToString());
        }

        sB.Append("Total price: $");
        sB.AppendLine(Total().ToString("F2"));
        return sB.ToString();
    }
}