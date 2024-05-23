public class Question
{
    public string Text { get; set; }
    public string[] Choices { get; set; }
    public int CorrectAnswerIndex { get; set; }

    public Question(string text, string[] choices, int correctAnswerIndex)
    {
        Text = text;
        Choices = choices;
        CorrectAnswerIndex = correctAnswerIndex;
    }
}
