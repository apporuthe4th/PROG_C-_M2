namespace PJ4temp;

class Program
{

    internal class Formulier
    {
        internal int Sterren {get; set;}
        internal string Feedback {get; set;}

        public override string ToString()
        {
            return Sterren  + Feedback;
        }

    } 
    static void Main(string[] args)
    {
        double[] prijzen = new double[] {0.99, 5.60, 10.11};
        string[] artiekelen = new string[] {"candy", "drugs", "help me"};
        Formulier[] _formulier = new Formulier[2];
        _formulier[0] = new Formulier()
        {
            Sterren = 10,
            Feedback = "expensiiive"
        };
        _formulier[1] = new Formulier()
        {
          Sterren = 67,
          Feedback = "hollow hungy"  
        };

        for (int i = 0; i < _formulier.Length; i++)
        {
            Console.WriteLine($"{_formulier[i].Sterren} {_formulier[i].Feedback}");
        } //vraag


         for (int i = 0; i < prijzen.Length; i++)
        {
            Console.WriteLine(prijzen[i]);
        }
    foreach (Formulier formulier in _formulier)
    {
        Console.WriteLine(formulier);
    }
    }
}
