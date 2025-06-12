namespace blazor_sample_site.Models
{
    public class Question
    {
        public string Text { get; set; } = string.Empty;

        public List<string> Options { get; set; } = new List<string>();

        /// <summary>
        /// Index i Options-listan som är rätt svar.
        /// </summary>
        public int CorrectAnswerIndex { get; set; }
    }
}