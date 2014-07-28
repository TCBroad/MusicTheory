namespace TheoryWeb.Domain
{
    using System;

    public class Chord
    {
        public Chord(int difficulty, params Note[] notes)
        {
            this.Note1 = notes[0];
            this.Note2 = notes[1];
            this.Note3 = notes[2];
            this.Note4 = notes[3];
            this.Difficulty = difficulty;

            this.Id = Guid.NewGuid();
        }

        public Note Note1 { get; set; }

        public Note Note2 { get; set; }

        public Note Note3 { get; set; }

        public Note Note4 { get; set; }

        public string Third { get; set; }

        public string Seventh { get; set; }

        public Guid Id { get; private set; }

        public int Difficulty { get; set; }

        public string GetNotes(bool seventh)
        {
            if (seventh)
            {
                return string.Format(
                                     "{0} {1} {2} {3}",
                    this.Note1.GetEnumDescription(),
                    this.Note2.GetEnumDescription(),
                    this.Note3.GetEnumDescription(),
                    this.Note4.GetEnumDescription());
            }

            return string.Format("{0} {1} {2}", this.Note1.GetEnumDescription(), this.Note2.GetEnumDescription(), this.Note3.GetEnumDescription());
        }

        public string GetName(bool seventh)
        {
            return string.Format("{0} {1}", this.Note1.GetEnumDescription(), seventh ? this.Seventh : this.Third);
        }
    }
}