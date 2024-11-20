// Base class: Animalia
public class Animalia
{
    // Attribute for the class name
    protected string classF = "Animalia";

    // Method to identify the class
    public void Identify()
    {
        Console.WriteLine($"This belongs to the {classF} kingdom, which includes multicellular, eukaryotic, heterotrophic organisms.");
    }
}