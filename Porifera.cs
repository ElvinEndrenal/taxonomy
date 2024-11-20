// Derived class for Division/Phylum within Parazoa
public class Porifera : Parazoa
{
    // Additional attributes for the division
    private string divisionName = "Porifera";
    private string characteristic = "Body with pores";
    private string feedingMethod = "Filter feeding";

    // Method specific to Porifera
    public void DescribePorifera()
    {
        Console.WriteLine($"Phylum: {divisionName}. Characteristic: {characteristic}. Feeding: {feedingMethod}.");
    }

    // Additional method specific to Porifera
    public void Habitat()
    {
        Console.WriteLine($"{divisionName} organisms are mostly found in marine environments.");
    }

    // Another method to describe a Porifera trait
    public void PoriferaSpecialTrait()
    {
        Console.WriteLine($"{divisionName} lack true tissues and have specialized cells for various functions.");
    }
}