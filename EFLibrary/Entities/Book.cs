namespace EFLibrary.Entities;

public class Book
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal SalePrice { get; set; }
    public decimal CostPrice { get; set; }

    public int GenreId { get; set; }

    public Genre Genre { get; set; }

    public override string ToString()
    {
        return $"{Id} - {Name} - {SalePrice} - {CostPrice} - {Genre.Name}";
    }
}
