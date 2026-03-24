namespace ConsoleApp2.Equipment;

public class Laptop:Equipment
{
    
    public String brand { get; set; }
    
    public int Capacity { get; set; }

    public Laptop(String name, String brand, int capacity) : base(name)
    {
        this.brand = brand;
        this.Capacity = capacity;
    }
    
}