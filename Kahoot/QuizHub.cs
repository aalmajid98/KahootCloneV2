using Microsoft.AspNetCore.SignalR;
using System.Collections.Generic;
using System.Threading.Tasks;

public class QuizHub : Hub
{
    public async Task ReceiveQuestion(string question, List<string> answers)
    {
        // process the question and answers
    }
}
