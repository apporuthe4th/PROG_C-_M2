using System.Runtime.CompilerServices;

namespace PJ3Remake;

class Program
{
    class Quizvraag
    {
        internal string _vraag;
        internal string _antwoord;

        internal Quizvraag(string vraag, string antwoord)
        {
            _vraag = vraag;
            _antwoord = antwoord;
        }

    }
    class QuizVraagAntwoord
    {
        internal Quizvraag _vraag;

        internal bool goed;

        internal QuizVraagAntwoord(Quizvraag vraag, Quizvraag antwoord)
        {
            _vraag = vraag;
            goed = false;
        }
    }
    class Quiz
    {
        internal Quizvraag[] vragen;
        internal QuizVraagAntwoord[] ingevuldeAntwoord;

        internal Quiz(int aantalVragen, int aantalIngevuldeAntwoord)
        {
            vragen = new Quizvraag[aantalVragen];
            ingevuldeAntwoord = new QuizVraagAntwoord[aantalIngevuldeAntwoord];
        }

        internal void _VoegVraagToeOpIndex(int index, Quizvraag _vraag)
        {
            vragen[index] = _vraag;
        }
        internal void VoegVraagToeOpIndex(int index, string vraag, string antwoord)
        {
            Quizvraag quizvraag = new Quizvraag(vraag, antwoord);
            _VoegVraagToeOpIndex(index, quizvraag);


        }

    }


    internal static void Run()
    {

        Quiz quiz = new Quiz(10, 0);
        int quizlength = quiz.vragen.Length;
        Quizvraag quizVraag = new Quizvraag("hier vraag", "hiera antwoord");

        ArrayFill(quiz);
        foreach (var item in quiz.vragen)
        {
            Console.WriteLine(item);
        }
        ;

        for (int i = 0; i < quizlength; i++)
        {
            Console.WriteLine($"current index {i}: ");

            if (quiz.vragen[i] != null)
            {
                Console.WriteLine($"Question: {quiz.vragen[i]._vraag}, Answer: {quiz.vragen[i]._antwoord}");
            }
        }
    }

    private static Quiz ArrayFill(Quiz quiz)
    {
        quiz.VoegVraagToeOpIndex(0, "Which spooky 2001 GameCube game starring Mario’s brother got a reboot for Nintendo Switch in 2019?", "Luigi's Mansion");
        quiz.VoegVraagToeOpIndex(1, "2021 will see the release of what sixth game in the Halo franchise, continuing the adventures of Master Chief? Its name sounds as if the game’s story will continue in perpetuity.", "Halo Infinite");
        quiz.VoegVraagToeOpIndex(2, "In 2014, Google partnered with Game Freak and Nintendo as part of an April Fool's Day prank to create a new version of Google Maps populated by small creatures. This prank inspired what massively popular 2016 video game?", "Pokemon Go");
        quiz.VoegVraagToeOpIndex(3, "Which video game console released in 2006 pioneered the use of motion controls in its gameplay?", "Nintendo Wii");
        quiz.VoegVraagToeOpIndex(4, "What Konami game from September 1998 was initially released to the European arcade audience under the name Dancing Stage?", "Dance Dance Revolution");
        quiz.VoegVraagToeOpIndex(5, "In Mario Kart, the power-up that seeks out the player in first position and explodes on impact is a shell that is what color?", "Blue");
        quiz.VoegVraagToeOpIndex(6, "What third-person shooter video game developed by Nintendo was first released in 2015 and features characters known as inklings that can transform between human and squid-like forms?", "Splatoon");
        quiz.VoegVraagToeOpIndex(7, "In Super Mario Kart, the first game in Nintendo's racing franchise, which of the playable characters has the shortest names?", "Toad");
        quiz.VoegVraagToeOpIndex(8, "Neill Blomkamp is a South African-born film director, producer, and screenwriter particularly known for his work in the science fiction genre. His feature film debut came in 2009 with the well-received District 9, but only after a project to adapt a popular video game franchise fell through (Blomkamp was attached as the director). What is the name of this franchise, which debuted a character that later lent its name to Microsoft’s version of Apple's Siri?", "Halo");
        quiz.VoegVraagToeOpIndex(9, "Harry must collect treasures including gold, diamonds, and money without landing in quicksand or falling into an opening in the ground in what classic 1982 Atari game with an exclamation point in the title?", "Pitfall");
        return quiz;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Run();


    }
}
