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
                             new Chord(Note.C, Note.E, Note.G, Note.B) { Name = "Maj", SeventhName = "M7" },
                             new Chord(Note.D, Note.F, Note.A, Note.C) { Name = "Min", SeventhName = "m7" },
                             new Chord(Note.E, Note.G, Note.B, Note.D) { Name = "Min", SeventhName = "m7" },
                             new Chord(Note.F, Note.A, Note.C, Note.E) { Name = "Maj", SeventhName = "M7" },
                             new Chord(Note.G, Note.B, Note.D, Note.F) { Name = "Maj", SeventhName = "7" },
                             new Chord(Note.A, Note.C, Note.E, Note.G) { Name = "Min", SeventhName = "m7" },
                             new Chord(Note.B, Note.D, Note.F, Note.A) { Name = "Dim", SeventhName = "m7b5" }
                         };

            return chords;
        }
    }
}