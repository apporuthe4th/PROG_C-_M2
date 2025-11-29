namespace RijSchool;

class RijSchool

{

    static void Main(string[] args)
    {
        
    Auto auto1 = new Auto()
    {
        automaat=true,
        kenteken= "AAAAAA24",
        kilometerstand=2000,
        merk= "volkswagen"
    };
        Auto auto2 = new Auto()
    {
        automaat=false,
        kenteken= "BBBBBBBBB",
        kilometerstand=8130130,
        merk= "volvo"
    };

        RijLeraar rijleraar = new RijLeraar
        {
            leeftijd = 30,
            naam = "john",
            zzp = false

        };

        LesUur lesUur = new LesUur()
        {
            auto = auto1,
            rijLeraar = rijleraar,
            tijd = 1130,
            
            
        };

        LesPakket lesPakket = new LesPakket
        {
            urenGekocht = 20,
            urenVerbruikt = 5,
            examenPogingen = 1,
            automaat = true
        };
        TheorieTest TheorieTest = new TheorieTest
        {
            aantalFouten = 11,
            gehaald = true,
            afnameDatum = DateTime.Now
        };

        RijTest rijTest = new RijTest
        {
            gehaald = true,
            datum = DateTime.Now
        };
        Student Student = new Student
        {
            naam = "seal",
            leeftijd = 15,
            lesPakket = lesPakket,
            leraar = rijleraar,
            theorieTest = TheorieTest,
            rijTest = rijTest
        };

        Console.WriteLine("Hello, World!" + auto1.automaat);
    }
}
