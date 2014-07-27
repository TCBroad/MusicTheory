namespace TheoryTest.Tasks
{
    using TheoryTest.Contracts;
    using TheoryTest.Models;

    public class ChordTasks : IChordTasks
    {
        public QuestionModel GetChord()
        {
            return new QuestionModel();
        }
    }
}