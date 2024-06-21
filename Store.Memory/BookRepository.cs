namespace Store.Memory
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] books = new Book[]
            {
                new Book(1, "Programming on C#"),
                new Book(2, "Programming on C++"),
                new Book(3, "Art of Programming"),
                new Book(4, "Clean Code")
            };
        public Book[] GetAllByTitle(string titlePart)
        {
            return books.Where(book => book.Title.ToLower().Contains(titlePart.ToLower())).ToArray();
        }
    }
}
