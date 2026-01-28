using System.ComponentModel;

namespace PJ4;

class Program
{
    internal class Formulier
    {
        internal int Sterren {get; set;}
        internal string Feedback{get; set;}
    }
    static void Main(string[] args)
    {
        double[] prijzen = new double[] {0.99, 5.60, 10.11};
        string[] artiekelen = {"snoep", "luxe brood", "lunch menu" };
        Formulier[] formulieren = new Formulier[2];
        formulieren[0] = new Formulier()
        {
            Feedback = "prijzig maar lekker",
            Sterren = 5
        };
        formulieren[1] = new Formulier()
        {
            Feedback = "ik wil slapen",
            Sterren = 2
        };
    for (int i = 0; i < prijzen.Length; i++)
        {
            Console.WriteLine($"{prijzen[i]}");
        }
    }
internal static void Run()
    {
        
    }
}
