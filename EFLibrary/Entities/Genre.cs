namespace EFLibrary.Entities;

public class Genre
{
    public int Id { get; set; }
    public string Name { get; set; }

    public List <Book> Books { get; set; }

    public override string ToString()
    {
        return $"{Id}-{Name}";
    }

}
