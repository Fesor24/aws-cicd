var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddAWSLambdaHosting(LambdaEventSource.HttpApi);

var app = builder.Build();

app.MapGet("/", () => "Hello World from Fesor Dev!!!");







//app.MapGet("/api/books/{id}", (int id) =>
//{
//    BookRepository repo = new();

//    var book = repo.GetBook(id);

//    if (book is null) return Results.NotFound("Book not found");

//    return Results.Ok(book);
//});

//app.MapGet("api/books", () =>
//{
//    BookRepository repo = new();

//    return Results.Ok(repo.GetBooks());
//});


//- dotnet test --no-build --verbosity normal

app.Run();

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int Version { get; set; }
    public string Author { get; set; }
}

public class BookRepository
{
    private readonly List<Book> _books = new()
    {
        new Book{Id = 1, Title = "Lord of The Rings", Author = "George Martin", Version = 1},
        new Book{Id = 2, Title = "Purple Hibiscus", Author = "Chimamda Ngozi", Version = 3},
        new Book{Id = 3, Title = "German Army", Author = "Bernard Shaw", Version = 2},
        new Book{Id = 4, Title = "Game of Thrones", Author = "George Martin", Version = 4},
    };

    public Book? GetBook(int id) =>
        _books.FirstOrDefault(x => x.Id == id);

    public List<Book> GetBooks() => _books;   
}
