namespace TheoryWeb.Tasks
{
    using System;

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
            difficulty--;
            if (difficulty < 1)
            {
                difficulty = 0;
            }

            var chord = this.BuildChord(difficulty);
            var seventh = this.random.Next(0, 2) == 1;

            return new QuestionModel { Chord = chord.GetNotes(seventh), Name = chord.GetName(seventh), Id = chord.Id, Key = chord.Key.GetEnumDescription() };
        }

        private Chord BuildChord(int key)
        {
            var thirds = new[] { "Maj", "Min", "Min", "Maj", "Maj", "Min", "Dim" };
            var sevenths = new[] { "Maj7", "m7", "m7", "Maj7", "7", "m7", "m7b5" };
            var scales = new Note[][]
                       {
                            new[] { Note.C, Note.D, Note.E, Note.F, Note.G, Note.A, Note.B } , 
                            new[] { Note.G, Note.A, Note.B, Note.C, Note.D, Note.E, Note.FSharp,  } , 
                            new[] { Note.D, Note.E, Note.FSharp, Note.G, Note.A, Note.B, Note.CSharp } , 
                            new[] { Note.A, Note.B ,Note.CSharp, Note.D, Note.E, Note.FSharp, Note.GSharp } , 
                            new[] { Note.E, Note.FSharp, Note.GSharp, Note.A, Note.B, Note.CSharp, Note.DSharp } , 
                            new[] { Note.B, Note.CSharp, Note.DSharp, Note.E, Note.FSharp, Note.GSharp, Note.ASharp } , 
                            new[] { Note.FSharp, Note.GSharp, Note.ASharp, Note.B, Note.CSharp, Note.DSharp, Note.F } 
                       };
            
            var root = this.random.Next() % 7;
            var currentKey = this.random.Next() % (key + 1);

            var note1 = scales[currentKey][(0 + root) % 7];
            var note2 = scales[currentKey][(2 + root) % 7];
            var note3 = scales[currentKey][(4 + root) % 7];
            var note4 = scales[currentKey][(6 + root) % 7];

            return new Chord(currentKey, note1, note2, note3, note4) { Third = thirds[root], Seventh = sevenths[root], Key = scales[currentKey][0] };
        }
    }
}