namespace TheoryWeb.Controllers.api
{
    using System.Web.Http;

    using TheoryWeb.Contracts;
    using TheoryWeb.Models;

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