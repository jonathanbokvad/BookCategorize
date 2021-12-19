using BookCategorize.Data;
using BookCategorize.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BookCategorize.Services
{
    public class BookServices : IBookServices
    {
        private readonly BookDbContext _context;
        public BookServices(BookDbContext context)
        {
            _context = context;
        }
        public void AddBook(Item book, CategorizeType categorizeType, Rating rating)
        {
            book.volumeInfo.CategorizeType = categorizeType;
            book.volumeInfo.Rating = rating;
            book.volumeInfo.DateAdded = DateTime.Now;
            _context.Item.Add(book);
            SaveChanges();
        }

        public void AddBookInformation(Volumeinfo volumeinfo)
        {
            _context.Volumeinfo.Add(volumeinfo);
            SaveChanges();
        }

        public void AddSearch(Searches search)
        {
            _context.Searches.Add(search);
            SaveChanges();
        }

        public void DeleteAllSearches()
        {
            var searches = _context.Searches.ToList();
            foreach (var searchesItem in searches)
            {
                _context.Searches.Remove(searchesItem);
            }
            SaveChanges();
        }

        public void DeleteBook(Item book)
        {
            _context.Item.Remove(book);
            SaveChanges();
        }

        public void DeleteBookInformation(Volumeinfo volumeinfo)
        {
            _context.Volumeinfo.Remove(volumeinfo);
            SaveChanges();
        }

        public void DeleteSearch(Searches search)
        {
            _context.Searches.Remove(search);
            SaveChanges();
        }

        public IEnumerable<Volumeinfo> GetAllBooksInformation()
        {
            return _context.Volumeinfo.Select(b => b).Include(b => b.imageLinks).OrderBy(b => b.title).ToList();
        }
        public Volumeinfo GetOneBook(Volumeinfo volumeinfo)
        {
            return _context.Volumeinfo.Where(b => b.Id == volumeinfo.Id).Select(b => b).Include(b => b.imageLinks).FirstOrDefault();
        }

        public Searches GetLastSearch()
        {
            return _context.Searches.OrderBy(s => s.Id).LastOrDefault();
        }

        public void UpdateBookInformation(Volumeinfo volumeinfo)
        {

            _context.Attach(volumeinfo);
            _context.Entry(volumeinfo).Property(b => b.CategorizeType).IsModified = true;
            _context.Entry(volumeinfo).Property(b => b.Rating).IsModified = true;
            SaveChanges();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
