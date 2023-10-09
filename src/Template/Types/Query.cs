namespace Template.Types;

[QueryType]
public static class Query
{
    public static Book GetBook()
        => new Book("C# in depth.", new Author("Jon Skeet"));

    public static string Hello() => "Hello";
}
