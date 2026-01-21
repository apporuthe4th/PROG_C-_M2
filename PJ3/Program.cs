namespace PJ3;

class Program

{

internal void run(string[] args)
    {
     QuizVraag quizVraag = new QuizVraag("haaq", "aaa");
     Quiz.VoegVraagToeOpIndex(2, "fish");

    }

static void Main(string[] args)
    {
        Program program = new Program();
        program.run(args);
    }

}


