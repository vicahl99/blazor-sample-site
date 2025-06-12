using blazor_sample_site.Models;

namespace blazor_sample_site.Services;

public interface IQuizService
{
    bool IsFinished { get; }

    Task LoadQuestionsAsync();
    
    Question? GetCurrentQuestion();
    
    void SubmitAnswer(int selectedIndex);
    
    void NextQuestion();
    
    bool HasNextQuestion();
    
    QuizResult GetResult();
    void Reset();
}