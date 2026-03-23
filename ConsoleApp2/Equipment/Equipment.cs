namespace ConsoleApp2.Equipment;

public abstract class Equipment
{
    private static int counter = 0;
    public int Id { get; }
    public string Name { get; set; }
    
    public bool IsAvailable { get; set; }


    public Equipment(String name)
    {
        this.Id = counter++;
        this.Name = name;
        this.IsAvailable = true;
    }

    
    
    
}