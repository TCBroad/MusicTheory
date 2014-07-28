namespace TheoryWeb.Domain
{
    using System.ComponentModel;

    public enum Note
    {
        A,
        [Description("A#")]
        ASharp,
        B,
        C,
        [Description("C#")]
        CSharp,
        D,
        [Description("D#")]
        DSharp,
        E,
        F,
        [Description("F#")]
        FSharp,
        G,
        [Description("G#")]
        GSharp
    }
}