namespace RijSchool;

class RijSchool
{
    static void Main(string[] args)
    {
        Auto auto1 = new Auto()
        {
            automaat = true,
            kenteken = "AAAAAA24",
            kilometerstand = 2000,
            merk = "volkswagen"
        };
        Auto auto2 = new Auto()
        {
            automaat = false,
            kenteken = "BBBBBBBBB",
            kilometerstand = 8130130,
            merk = "volvo"
        };

        RijLeraar rijleraar = new RijLeraar
        {
            leeftijd = 30,
            naam = "john",
            zzp = false
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

        Student student = new Student
        {
            naam = "seal",
            leeftijd = 15,
            lesPakket = lesPakket,
            leraar = rijleraar,
            theorieTest = TheorieTest,
            rijTest = rijTest
        };

        LesUur[] lesUrenArray = new LesUur[3];
        lesUrenArray[0] = new LesUur() { tijd = 16, auto = auto1, rijLeraar = rijleraar, student = student };
        lesUrenArray[1] = new LesUur() { tijd = 14, auto = auto1, rijLeraar = rijleraar, student = student };
        lesUrenArray[2] = new LesUur() { tijd = 15, auto = auto2, rijLeraar = rijleraar, student = student };

        Dag dag = new Dag
        {
            datum = DateTime.Now,
            LesUren = lesUrenArray,
        };
        student.dag = dag;

        Console.WriteLine($"student {student.naam}; leeftijd {student.leeftijd}, heeft {student.dag.LesUren.Length} lesuren gepland.");
    }
}
