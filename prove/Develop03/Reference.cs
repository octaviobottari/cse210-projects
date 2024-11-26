public class Reference
{
    public string Book { get; private set; }
    public int Chapter { get; private set; }
    public string Verse { get; private set; }

    public Reference(string book, int chapter, int startVerse, int? endVerse = null)
    {
        Book = book;
        Chapter = chapter;
        Verse = endVerse.HasValue ? $"{startVerse}-{endVerse}" : startVerse.ToString();
    }

    public override string ToString()
    {
        return $"{Book} {Chapter}:{Verse}";
    }
}
