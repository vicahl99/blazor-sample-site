using blazor_sample_site.Models;
using System.Threading.Tasks;

namespace blazor_sample_site.Services
{
    public interface IQuizService
    {
        /// <summary>
        /// Laddar eller initierar frågorna.
        /// </summary>
        Task LoadQuestionsAsync();

        /// <summary>
        /// Hämtar den aktuella frågan.
        /// </summary>
        /// <returns>Nuvarande fråga eller null om slut.</returns>
        Question? GetCurrentQuestion();

        /// <summary>
        /// Registrerar ett svar på aktuell fråga.
        /// </summary>
        /// <param name="selectedIndex">Index på valt alternativ.</param>
        void SubmitAnswer(int selectedIndex);

        /// <summary>
        /// Går vidare till nästa fråga.
        /// </summary>
        void NextQuestion();

        /// <summary>
        /// Kollar om det finns fler frågor efter den aktuella.
        /// </summary>
        /// <returns>True om fler frågor finns.</returns>
        bool HasNextQuestion();

        /// <summary>
        /// Returnerar quizets resultat.
        /// </summary>
        /// <returns>Resultatdata.</returns>
        QuizResult GetResult();

        /// <summary>
        /// Om quizet är klart.
        /// </summary>
        bool IsFinished { get; }
        void Reset();
    }
}