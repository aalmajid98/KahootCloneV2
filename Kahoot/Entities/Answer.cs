public class Answer
{
    /// <summary>
    /// The unique identifier for the answer.
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    /// The text of the answer.
    /// </summary>
    public string? Text { get; set; }
    /// <summary>
    /// Whether the answer is correct.
    /// </summary>
    public bool IsCorrect { get; set; }
    /// <summary>
    /// The question to which the answer belongs.
    /// </summary>
    public int QuestionId { get; set; }
    /// <summary>
    /// the relationship between an answer and its corresponding question
    /// </summary>
    public virtual Question? Question { get; set; }
}
