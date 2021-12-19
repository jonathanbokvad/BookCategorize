using BookCategorize.Models;

namespace BookCategorize.Services
{
    public interface IBookServices
    {
        IEnumerable<Volumeinfo> GetAllBooksInformation();
        Volumeinfo GetOneBook(Volumeinfo volumeinfo);
        void UpdateBookInformation(Volumeinfo volumeinfo);
        Searches GetLastSearch();
        void AddBook(Item book, CategorizeType categorizeType, Rating rating);
        void AddBookInformation(Volumeinfo volumeinfo);
        void AddSearch(Searches search);
        void DeleteBook(Item book);
        void DeleteBookInformation(Volumeinfo volumeinfo);
        void  DeleteSearch(Searches search);
        void DeleteAllSearches();
        void SaveChanges();


    }
}
