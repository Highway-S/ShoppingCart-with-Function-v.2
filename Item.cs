public class Item
{
    public string Name { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }
    public bool IsSelected { get; set; }

    public Item(string name, double price)
    {
        Name = name;
        Price = price;
        Quantity = 0;
        IsSelected = false;
    }

    public double CalculateTotal()
    {
        return Price * Quantity;
    }
}
