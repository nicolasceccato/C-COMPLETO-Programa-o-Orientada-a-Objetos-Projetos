namespace ExercSecao9.Entities;

public class Product
{
    public string Name { get; set; }
    public double Price { get; set; }

    public Product(string name, double price)
    {
        this.Name = name;
        this.Price = price;
    }

}