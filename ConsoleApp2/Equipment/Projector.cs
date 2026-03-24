namespace ConsoleApp2.Equipment;

public class Projector:Equipment
{
    public int Resolution { get; set; }
    public int Brightness { get; set; }

    public Projector(String name, int resolution, int brightness) : base(name)
    {
        this.Resolution = resolution;
        this.Brightness = brightness;
    }
}