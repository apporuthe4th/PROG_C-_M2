using System.Security.Cryptography.X509Certificates;

namespace Functions;

class Program
{


   internal static void Main(string[] args)
    {
        
        Program program = new Program();
  
        program.what(args);
        program.arrayrandomizer(args);
        int bean = 10;

        string hii = "wsggggg";

    }
    public void SayHello(string[]hii) 
{
    Console.WriteLine(hii);
}
    internal void arrayrandomizer(string[] args)
    {
        Program program = new Program();
        Random rnd = new Random();
        int RandomINT = rnd.Next(1, 8);
        string[] V_List = new string[7];
        {
            program.V1(args);
            program.V2(args);
            program.V3(args);
            program.V4(args);
            program.V5(args);
            program.V6(args);
            program.V7(args);
        }
        string randoquestion = V_List[RandomINT];
        Console.WriteLine(randoquestion);

    }
    internal void what(string[] args)
    {

        Console.WriteLine("func test");
    }


    internal void V1(string[] args)
    {
        Console.WriteLine("how many ");
        string anw = Console.ReadLine();
        Console.WriteLine(anw);
    }
        internal void V2(string[] args)
    {
        Console.WriteLine("How long do you think you'd survive in a zombie apocalypse?");
        string anw = Console.ReadLine();
        Console.WriteLine(anw);
    }
        internal void V3(string[] args)
    {
        Console.WriteLine("- What secret conspiracy would you like to actually start letting other people know?");
        string anw = Console.ReadLine();
        Console.WriteLine(anw);
    }
        internal void V4(string[] args)
    {
        Console.WriteLine("If you can still remember, what are your funniest childhood memories?");
        string anw = Console.ReadLine();
        Console.WriteLine(anw);
    }
        internal void V5(string[] args)
    {
        Console.WriteLine("What would you do if you won a million dollars?");
        string anw = Console.ReadLine();
        Console.WriteLine(anw);
    }
            internal void V6(string[] args)
    {
        Console.WriteLine("What would you do if you won a million fishes?");
        string anw = Console.ReadLine();
        Console.WriteLine(anw);
    }

            internal string V7(string[] args)
    {
        Console.WriteLine("What would you do if you won a million dollars?");
        string anw = Console.ReadLine();
        return anw;
    }

}

   