namespace WebAPI1.repository
{
    public interface IEmployee
    {
        Task<List<BooksModel>> getAllBooks();
    }
}
