namespace TheoryTest.Controllers.api
{
    using System.Web.Http;

    using TheoryTest.Contracts;
    using TheoryTest.Models;

    public class QuestionController : ApiController
    {
        private readonly IChordTasks tasks;

        public QuestionController(IChordTasks tasks)
        {
            this.tasks = tasks;
        }

        [HttpGet]
        public QuestionModel Get()
        {
            return this.tasks.GetChord();
        }
    }
}