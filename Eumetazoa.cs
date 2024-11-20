// Derived class: SubKingdom (Parazoa and Eumetazoa)
public class Eumetazoa : Animalia
{
    // Additional attributes for the subkingdom
    protected string subKingdomName = "Eumetazoa";
    protected string feature = "Possesses true tissues";

    // Method specific to Eumetazoa
    public void Describe()
    {
        Console.WriteLine($"Subkingdom: {subKingdomName}. Feature: {feature}.");
    }

    // Additional method for Eumetazoa
    public void EumetazoaSpecialization()
    {
        Console.WriteLine($"{subKingdomName} organisms have complex tissues and organs.");
    }
}