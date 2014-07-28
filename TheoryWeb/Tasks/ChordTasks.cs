namespace TheoryWeb.Tasks
{
    using System;
    using System.Linq;

    using TheoryWeb.Contracts;
    using TheoryWeb.Domain;
    using TheoryWeb.Models;

    public class ChordTasks : IChordTasks
    {
        private readonly Random random;

        public ChordTasks()
        {
            this.random = new Random();
        }

        public QuestionModel GetChord(int difficulty)
        {
            if (difficulty < 1)
            {
                difficulty = 1;
            }

            var chord = MusicData.Chords.Where(x => x.Difficulty <= difficulty).OrderBy(x => Guid.NewGuid()).First();
            var seventh = this.random.Next(0, 2) == 1;

            return new QuestionModel { Chord = chord.GetNotes(seventh), Name = chord.GetName(seventh), Id = chord.Id };
        }
    }
}