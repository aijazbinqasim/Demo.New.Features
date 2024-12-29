namespace Demo.New.Features.Models
{
    public class Book
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public string? Author { get; set; }
        public DateTime? PublishedOn { get; set; }
    }

    public class BookStore
    {

        Book b = new()
        {
            Id = 1,
            Title = "C# 10",
            Author = "Aijaz",
            PublishedOn = DateTime.Now
        };


    }
}
