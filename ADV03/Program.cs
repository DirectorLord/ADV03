namespace ADV03;
public class Program
{
    #region Question1
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }

        public Book(string isbn, string title, string[] authors, DateTime publicationDate, decimal price)
        {
            this.ISBN = isbn;
            this.Title = title;
            this.Authors = authors;
            this.PublicationDate = publicationDate;
            this.Price = price;
        }

        public override string ToString()
        {
            return $"ISBN: {ISBN}, Title: {Title}, Authors: {string.Join(", ", Authors)}, Publication Date: {PublicationDate}, Price: {Price:C}";
        }
    }

    public class BookFunctions
    {
        public static string GetTitle(Book b)
        {
            return b.Title;
        }

        public static string GetAuthors(Book b)
        {
            return string.Join(", ", b.Authors);
        }

        public static string GetPublicationDate(Book b)
        {
            return b.PublicationDate.ToShortDateString();
        }

        public static string GetPrice(Book b)
        {
            return b.Price.ToString("C");
        }
    }
    #endregion


    public static void Main(String[] args)
    {

    }
}