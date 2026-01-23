using System.Runtime.Intrinsics.Wasm;
using System.Security.Cryptography.X509Certificates;

namespace Lists;

class Program
{
    static void Main(string[] args)
    {
        List<string> charList = new List<string>()
     {
        "Pac-Man"
        ,"Samus"
        ,"Crash Bandicoot"
        ,"Spyro the Dragon"
        ,"Donkey Kong"
        ,"Mario"
        ,"Luigi"
        ,"Astro"
        ,"Solid Snake"
        ,"Master Chief"
        ,"Kratos"
        ,"Sonic the Hedgehog"
        ,"Link"
       };

        for (int i = 0; i < charList.Count; i++)
        {
            Console.WriteLine(charList[i]);
        }
        charList.Remove("Pac-Man");

        List<double> reviews = new List<double>()
        {
            123
            ,123123
            ,1231
            ,23
            ,12

        };
        reviews.Remove(123);
        reviews.RemoveAt(0);
        for (int i = 0; i < reviews.Count; i++)
        {
            Console.WriteLine(reviews[i]);
        }

           List<Pickup> pick = new List<Pickup>();


    }

    
        
}

