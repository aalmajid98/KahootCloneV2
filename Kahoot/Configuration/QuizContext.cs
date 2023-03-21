using System;
using Microsoft.EntityFrameworkCore;

namespace Kahoot.Configuration {
    public class QuizContext : DbContext {
        /// <summary>
        /// The connection string for the database.
        /// </summary>
        public string ConnectionString { get; set; }
        /// <summary>
        /// The name of the database.
        /// </summary>
        public string Database { get; set; }
    }
}