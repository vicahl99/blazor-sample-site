namespace blazor_sample_site.Models;


    public class QuizResult
    {
        /// <summary>
        /// Totalt antal frågor i quizet.
        /// </summary>
        public int TotalQuestions { get; set; }

        /// <summary>
        /// Antal rätta svar.
        /// </summary>
        public int CorrectAnswers { get; set; }

        /// <summary>
        /// Hur lång tid quizet tog.
        /// </summary>
        public TimeSpan Duration { get; set; }
    }
