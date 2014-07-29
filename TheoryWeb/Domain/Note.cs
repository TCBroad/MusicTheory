namespace TheoryWeb.Domain
{
    using System.ComponentModel;

    public enum Note
    {
        C = 1,
        [Description("C#")]
        CSharp = 2,
        D = 3,
        [Description("D#")]
        DSharp = 4,
        E = 5,
        F = 6,
        [Description("F#")]
        FSharp = 7,
        G = 8,
        [Description("G#")]
        GSharp = 9,
        A = 10,
        [Description("A#")]
        ASharp = 11,
        B = 12
    }
}