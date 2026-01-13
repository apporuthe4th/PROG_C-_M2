namespace PJ3;

internal class QuizVraag
{
    internal QuizVraag()
    { 
    
    
    }
    internal string vraag;
    internal string antwoord;

    internal QuizVraag(string vraag, string antwoord)
    {
    this.vraag = vraag;
    this.antwoord = antwoord;
    }
    private void Run()
    {
        QuizVraag quizvraag = new QuizVraag("hier vraag", "hier antwoord");

    }
}


