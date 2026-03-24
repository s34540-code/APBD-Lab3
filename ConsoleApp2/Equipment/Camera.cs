namespace ConsoleApp2.Equipment;

public class Camera:Equipment
{
    
    public bool flashOn { get; set; }
    
    public double maxRange{get;set;}

    public Camera(String name, bool flashOn, double maxRange) : base(name)
    {
        this.flashOn = flashOn;
        this.maxRange = maxRange;
        
    }
    
}