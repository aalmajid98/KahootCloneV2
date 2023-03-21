using Kahoot.Configuration;
using Microsoft.AspNetCore.Mvc;

namespace Kahoot.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    /// <summary>
    /// The controller for the Quiz API.
    /// </summary>
    public class QuizController : ControllerBase
    {
        private readonly QuizContext _context;

        public QuizController(QuizContext context)
        {
            _context = context;
        }

        // Controller actions that use _context to perform CRUD operations
    }
}