using PJ3;

class Quiz
{
    internal QuizVraag[] vragen;
    internal QuizVraagAntwoord[] ingevuldeAntwoorden;
    internal Quiz()
    {
        vragen = new QuizVraag[aantalVragen];
    }
    vragen[index] = vraag;

     void VoegVraagToeOpIndex(int index, QuizVraag vraag) { 
        vragen[index] = vraag;
    }

     void VoegVraagToeOpIndex(int index, string vraag, string antwoord)
    {
        VoegVraagToeOpIndex(index, new QuizVraag("What 1997 N64 video game, features James Bond and is named after the 1995 film ?", "Answer: GoldenEye"))
    }
}