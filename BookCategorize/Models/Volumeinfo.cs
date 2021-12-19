using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookCategorize.Models
{
    public class Volumeinfo
    {
        public int Id { get; set; }
        public string title { get; set; }
        public string[] authors { get; set; }
        public string publishedDate { get; set; }
        public string description { get; set; }
        public Imagelinks imageLinks { get; set; }
        public CategorizeType CategorizeType { get; set; }
        public Rating Rating { get; set; } 
        public DateTime DateAdded { get; set; }

        [NotMapped]
        public string AllAuthors 
        { 
            get 
            {
                if(authors != null)
                {
                    return string.Join(", ", authors.ToArray());
                }
                return string.Empty;
            } 
            set {}
        }
    }
    public class Imagelinks
    {
        [Key]
        public string smallThumbnail { get; set; }
        public string thumbnail { get; set; }
    }

    public enum CategorizeType
    {
        [Display(Name = "Read")]
        Read,
        [Display(Name = "Want to read")]
        WantToRead,
        [Display(Name = "Reading")]
        Reading
    }
    public enum Rating
    {

        [Display(Name = "Not rated")]
        NotYetRated,
        [Display(Name = "1")]
        One,
        [Display(Name = "2")]
        Two,
        [Display(Name = "3")]
        Three,
        [Display(Name = "4")]
        Four,
        [Display(Name = "5")]
        Five
    }

}