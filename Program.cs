/* 
    AUTHOR: Endrenal, John Elvin S.
    SECTION: ICT201-A
    DATE: November 8, 2024
    ACTIVITY: 06 Exercise A2

    Animalia : Identify()
    |
    |___ Parazoa : Describe()
    |     |
    |     |___ Porifera : DescribePorifera()
    |           |
    |           |___ Habitat()
    |           |___ PoriferaSpecialTrait()
    |
    |___ Eumetazoa : Describe()
            |
            |___ Cnidaria : DescribeCnidaria()
                |
                |___ Habitat()
                |___ CnidariaSpecialTrait()

    REFERENCES:
        - https://sanpablosti.sharepoint.com/:u:/s/ICT201-AOnline/ETNsV7J_JsNLkKr7dEGEomYBta3bqZUbfuDmGhgHI450UQ?e=hDbBdm
 */

using System;

namespace Taxonomy
{
    // Main program to demonstrate the hierarchy
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate and invoke methods for each class
            Animalia animalia = new Animalia();
            Parazoa parazoa = new Parazoa();
            Eumetazoa eumetazoa = new Eumetazoa();
            Porifera porifera = new Porifera();
            Cnidaria cnidaria = new Cnidaria();

            // Animalia methods
            animalia.Identify();
            
            // Parazoa methods
            parazoa.Describe();
            parazoa.ParazoaSpecialization();

            // Eumetazoa methods
            eumetazoa.Describe();
            eumetazoa.EumetazoaSpecialization();

            // Porifera methods
            porifera.DescribePorifera();
            porifera.Habitat();
            porifera.PoriferaSpecialTrait();

            // Cnidaria methods
            cnidaria.DescribeCnidaria();
            cnidaria.Habitat();
            cnidaria.CnidariaSpecialTrait();
        }
    }
}
