public class Response
{
    /// <summary>
    /// The unique identifier for the response.
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    /// The question to which the response belongs.
    /// </summary>
    public int QuestionId { get; set; }
    /// <summary>
    /// The relationship between a response and its corresponding question.
    /// </summary>
    public virtual Question Question { get; set; }
    /// <summary>
    /// The answer to which the response belongs.
    /// </summary>
    public int AnswerId { get; set; }
    /// <summary>
    /// The relationship between a response and its corresponding answer.
    /// </summary>
    public virtual Answer Answer { get; set; }
    /// <summary>
    /// Whether the response is correct.
    /// </summary>
    public bool IsCorrect { get; set; }
    /// <summary>
    /// The user who submitted the response.
    /// </summary>
    public string UserId { get; set; }
}