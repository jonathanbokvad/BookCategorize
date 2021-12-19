using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace BookCategorize.Models
{

    public class SearchBookModel
    {
        public int Id { get; set; }
        public int totalItems { get; set; }
        public IEnumerable<Item> items { get; set; }
    }
}