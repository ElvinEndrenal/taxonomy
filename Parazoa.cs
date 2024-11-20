// Derived class: SubKingdom (Parazoa and Eumetazoa)
public class Parazoa : Animalia
{
    // Additional attributes for the subkingdom
    protected string subKingdomName = "Parazoa";
    protected string feature = "Lacks true tissues and organs";

    // Method specific to Parazoa
    public void Describe()
    {
        Console.WriteLine($"Subkingdom: {subKingdomName}. Feature: {feature}.");
    }

    // Additional method for Parazoa
    public void ParazoaSpecialization()
    {
        Console.WriteLine($"{subKingdomName} organisms exhibit a simple body structure.");
    }
}