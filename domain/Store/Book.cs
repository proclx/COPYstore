namespace Store
{
    public class Book
    {
        public int Id { get; }
        public string Title { get; }
        public Book(int Id, string Title)
        {
            this.Id = Id;
            this.Title = Title;
        }
    }
}
