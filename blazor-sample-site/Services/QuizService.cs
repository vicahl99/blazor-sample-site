using blazor_sample_site.Models;

namespace blazor_sample_site.Services
{
    public class QuizService : IQuizService
    {
        private List<Question> _questions = new();
        private int _currentIndex = 0;
        private int _correctAnswers = 0;
        private DateTime _startTime;

        public bool IsFinished { get; private set; } = false;

        public Task LoadQuestionsAsync()
        {
            _questions = new List<Question>
            {
                new Question
                {
                    Text = "Vad är huvudstaden i Sverige?",
                    Options = new List<string> { "Göteborg", "Stockholm", "Malmö", "Uppsala" },
                    CorrectAnswerIndex = 1
                },
                new Question
                {
                    Text = "Vilken planet är närmast solen?",
                    Options = new List<string> { "Venus", "Jorden", "Merkurius", "Mars" },
                    CorrectAnswerIndex = 2
                },
                new Question
                {
                    Text = "Vilket år grundades Microsoft?",
                    Options = new List<string> { "1975", "1980", "1985", "1990" },
                    CorrectAnswerIndex = 0
                }
            };

            _currentIndex = 0;
            _correctAnswers = 0;
            IsFinished = false;
            _startTime = DateTime.Now;

            return Task.CompletedTask;
        }

        public Question? GetCurrentQuestion()
        {
            if (_currentIndex < _questions.Count)
                return _questions[_currentIndex];
            return null;
        }

        public void SubmitAnswer(int selectedIndex)
        {
            if (IsFinished) return;

            var current = GetCurrentQuestion();
            if (current != null && selectedIndex == current.CorrectAnswerIndex)
            {
                _correctAnswers++;
            }
        }

        public void NextQuestion()
        {
            _currentIndex++;
            if (_currentIndex >= _questions.Count)
                IsFinished = true;
        }

        public bool HasNextQuestion() => _currentIndex + 1 < _questions.Count;

        public QuizResult GetResult()
        {
            return new QuizResult
            {
                TotalQuestions = _questions.Count,
                CorrectAnswers = _correctAnswers,
                Duration = DateTime.Now - _startTime
            };
        }
        public void Reset()
        {
            _currentIndex = 0;
            _correctAnswers = 0;
            IsFinished = false;
            _questions.Clear();
        }

    }
}
