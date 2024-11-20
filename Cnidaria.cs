// Derived class for Division/Phylum within Eumetazoa
public class Cnidaria : Eumetazoa
{
    // Additional attributes for the division
    private string divisionName = "Cnidaria";
    private string bodyForm = "Two main body forms: polyp and medusa";
    private string defenseMechanism = "Specialized cells called cnidocytes";

    // Method specific to Cnidaria
    public void DescribeCnidaria()
    {
        Console.WriteLine($"Phylum: {divisionName}. Body form: {bodyForm}. Defense: {defenseMechanism}.");
    }

    // Additional method specific to Cnidaria
    public void Habitat()
    {
        Console.WriteLine($"{divisionName} organisms are found in aquatic environments.");
    }

    // Another method to describe a Cnidaria trait
    public void CnidariaSpecialTrait()
    {
        Console.WriteLine($"{divisionName} have a unique defense system with cnidocytes for capturing prey.");
    }
}