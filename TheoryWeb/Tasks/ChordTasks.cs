namespace TheoryWeb.Tasks
{
    using TheoryWeb.Contracts;
    using TheoryWeb.Models;

    public class ChordTasks : IChordTasks
    {
        public QuestionModel GetChord()
        {
            return new QuestionModel();
        }
    }
}