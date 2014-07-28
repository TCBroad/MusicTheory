namespace TheoryWeb.Domain
{
    using System.Collections.Generic;
    using System.Linq;

    public static class MusicData
    {
        public static List<Chord> Chords;

        static MusicData()
        {
            Chords = GetChords().ToList();
            
        }

        public static IEnumerable<Chord> GetChords()
        {
            var chords = new List<Chord>
                         {
                             new Chord(1, Note.C, Note.E, Note.G, Note.B) { Third = "Maj", Seventh = "M7" },
                             new Chord(1, Note.D, Note.F, Note.A, Note.C) { Third = "Min", Seventh = "m7" },
                             new Chord(1, Note.E, Note.G, Note.B, Note.D) { Third = "Min", Seventh = "m7" },
                             new Chord(1, Note.F, Note.A, Note.C, Note.E) { Third = "Maj", Seventh = "M7" },
                             new Chord(1, Note.G, Note.B, Note.D, Note.F) { Third = "Maj", Seventh = "7" },
                             new Chord(1, Note.A, Note.C, Note.E, Note.G) { Third = "Min", Seventh = "m7" },
                             new Chord(1, Note.B, Note.D, Note.F, Note.A) { Third = "Dim", Seventh = "m7b5" },

                             new Chord(2, Note.G, Note.B, Note.D, Note.FSharp) { Third = "Maj", Seventh = "M7" },
                             new Chord(2, Note.A, Note.C, Note.E, Note.G) { Third = "Min", Seventh = "m7" },
                             new Chord(2, Note.B, Note.D, Note.FSharp, Note.A) { Third = "Min", Seventh = "m7" },
                             new Chord(2, Note.C, Note.E, Note.G, Note.B) { Third = "Maj", Seventh = "M7" },
                             new Chord(2, Note.D, Note.FSharp, Note.A, Note.C) { Third = "Maj", Seventh = "7" },
                             new Chord(2, Note.E, Note.G, Note.B, Note.D) { Third = "Min", Seventh = "m7" },
                             new Chord(2, Note.FSharp, Note.A, Note.C, Note.E) { Third = "Dim", Seventh = "m7b5" },

                             new Chord(3, Note.D, Note.FSharp, Note.A, Note.CSharp) { Third = "Maj", Seventh = "M7" },
                             new Chord(3, Note.E, Note.G, Note.B, Note.D) { Third = "Min", Seventh = "m7" },
                             new Chord(3, Note.FSharp, Note.A, Note.CSharp, Note.E) { Third = "Min", Seventh = "m7" },
                             new Chord(3, Note.G, Note.B, Note.D, Note.FSharp) { Third = "Maj", Seventh = "M7" },
                             new Chord(3, Note.A, Note.CSharp, Note.E, Note.G) { Third = "Maj", Seventh = "7" },
                             new Chord(3, Note.B, Note.D, Note.FSharp, Note.A) { Third = "Min", Seventh = "m7" },
                             new Chord(3, Note.CSharp, Note.E, Note.G, Note.B) { Third = "Dim", Seventh = "m7b5" },

                             new Chord(4, Note.A, Note.CSharp, Note.E, Note.GSharp) { Third = "Maj", Seventh = "M7" },
                             new Chord(4, Note.B, Note.D, Note.FSharp, Note.A) { Third = "Min", Seventh = "m7" },
                             new Chord(4, Note.CSharp, Note.E, Note.GSharp, Note.B) { Third = "Min", Seventh = "m7" },
                             new Chord(4, Note.D, Note.FSharp, Note.A, Note.CSharp) { Third = "Maj", Seventh = "M7" },
                             new Chord(4, Note.E, Note.GSharp, Note.B, Note.D) { Third = "Maj", Seventh = "7" },
                             new Chord(4, Note.FSharp, Note.A, Note.CSharp, Note.E) { Third = "Min", Seventh = "m7" },
                             new Chord(4, Note.GSharp, Note.B, Note.D, Note.FSharp) { Third = "Dim", Seventh = "m7b5" },

                             new Chord(5, Note.E, Note.G, Note.B, Note.DSharp) { Third = "Maj", Seventh = "M7" },
                             new Chord(5, Note.FSharp, Note.A, Note.CSharp, Note.E) { Third = "Min", Seventh = "m7" },
                             new Chord(5, Note.GSharp, Note.B, Note.DSharp, Note.FSharp) { Third = "Min", Seventh = "m7" },
                             new Chord(5, Note.A, Note.CSharp, Note.E, Note.GSharp) { Third = "Maj", Seventh = "M7" },
                             new Chord(5, Note.B, Note.DSharp, Note.FSharp, Note.A) { Third = "Maj", Seventh = "7" },
                             new Chord(5, Note.CSharp, Note.E, Note.GSharp, Note.B) { Third = "Min", Seventh = "m7" },
                             new Chord(5, Note.DSharp, Note.FSharp, Note.A, Note.CSharp) { Third = "Dim", Seventh = "m7b5" },

                             new Chord(6, Note.B, Note.DSharp, Note.FSharp, Note.ASharp) { Third = "Maj", Seventh = "M7" },
                             new Chord(6, Note.CSharp, Note.E, Note.GSharp, Note.B) { Third = "Min", Seventh = "m7" },
                             new Chord(6, Note.DSharp, Note.FSharp, Note.ASharp, Note.CSharp) { Third = "Min", Seventh = "m7" },
                             new Chord(6, Note.E, Note.GSharp, Note.B, Note.DSharp) { Third = "Maj", Seventh = "M7" },
                             new Chord(6, Note.FSharp, Note.ASharp, Note.CSharp, Note.E) { Third = "Maj", Seventh = "7" },
                             new Chord(6, Note.GSharp, Note.B, Note.DSharp, Note.FSharp) { Third = "Min", Seventh = "m7" },
                             new Chord(6, Note.ASharp, Note.CSharp, Note.E, Note.GSharp) { Third = "Dim", Seventh = "m7b5" },

                             new Chord(7, Note.FSharp, Note.ASharp, Note.CSharp, Note.F) { Third = "Maj", Seventh = "M7" },
                             new Chord(7, Note.GSharp, Note.B, Note.DSharp, Note.FSharp) { Third = "Min", Seventh = "m7" },
                             new Chord(7, Note.ASharp, Note.CSharp, Note.F, Note.GSharp) { Third = "Min", Seventh = "m7" },
                             new Chord(7, Note.B, Note.DSharp, Note.FSharp, Note.ASharp) { Third = "Maj", Seventh = "M7" },
                             new Chord(7, Note.CSharp, Note.F, Note.GSharp, Note.B) { Third = "Maj", Seventh = "7" },
                             new Chord(7, Note.DSharp, Note.FSharp, Note.ASharp, Note.CSharp) { Third = "Min", Seventh = "m7" },
                             new Chord(7, Note.F, Note.GSharp, Note.B, Note.DSharp) { Third = "Dim", Seventh = "m7b5" },
                         };

            return chords;
        }
    }
}