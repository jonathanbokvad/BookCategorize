using BookCategorize.Data;
using BookCategorize.Models;
using BookCategorize.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Data;
using System.Text;
using System.Text.Json;

namespace BookCategorize.Controllers
{
    public class BookController : Controller
    {
        IBookServices _services;
        public BookController(IBookServices services)
        {
            _services = services;
        }

        SearchBookModel booksSearched;
        Item book = new();
        Searches searches = new();

        #region Book API
        protected async Task OnInitializedAsync(string searchString)
        {
            var serviceProvider = new ServiceCollection().AddHttpClient().BuildServiceProvider();
            var httpClientFactory = serviceProvider.GetService<IHttpClientFactory>();
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://www.googleapis.com/books/v1/volumes?q={searchString}&maxResults=40&key=AIzaSyAu0toYWNzS93JSY3vVz8l1n-5rCxlDwck");
            var client = httpClientFactory.CreateClient();

            HttpResponseMessage response = await client.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                var books = await response.Content.ReadAsStringAsync();
                booksSearched = JsonConvert.DeserializeObject<SearchBookModel>(books);

            }
        }
        protected async Task OnInitializedAsync(Item itemBook)
        {
            var serviceProvider = new ServiceCollection().AddHttpClient().BuildServiceProvider();
            var httpClientFactory = serviceProvider.GetService<IHttpClientFactory>();
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://www.googleapis.com/books/v1/volumes/{itemBook.Id}");
            var client = httpClientFactory.CreateClient();

            HttpResponseMessage response = await client.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                var bookFound = await response.Content.ReadAsStringAsync();
                book = JsonConvert.DeserializeObject<Item>(bookFound);
            }
        }

        #endregion

        public async Task<ActionResult> Index(string searchString)
        {
            searches.TemporarySearch = searchString;

            if (/*_context.Searches.Count() <= 0 &&*/ searchString != null)
            {
                _services.AddSearch(searches);
                await OnInitializedAsync(searchString);
                return View(booksSearched);
            }
            else
            {
                searches =  _services.GetLastSearch();
                await OnInitializedAsync(searches.TemporarySearch);
                //_context.Searches.Remove(searches);
                //_context.SaveChanges();
                return View(booksSearched);
            }
        }

        public ActionResult SearchForm()
        {
            return View();
        }

        public IActionResult Details(Volumeinfo bookModel)
        {
            return View(_services.GetOneBook(bookModel));
        }

        public IActionResult Start()
        {
            return View(_services.GetAllBooksInformation());
        }
        public IActionResult Reading()
        {

            return View(_services.GetAllBooksInformation());
        }
        public IActionResult WantToRead()
        {

            return View(_services.GetAllBooksInformation());
        }
        public IActionResult Read()
        {

            return View(_services.GetAllBooksInformation());
        }

        public async Task<IActionResult> Save(Item itemBook, CategorizeType categorizeType, Rating rating)
        {
            await OnInitializedAsync(itemBook);
            _services.AddBook(book, categorizeType, rating);
            return RedirectToAction(nameof(Start));
        }

        public async Task<IActionResult> Create(Item itemBook)
        {
            await OnInitializedAsync(itemBook);
            return View(book);
        }

        public IActionResult Delete(Volumeinfo bookModel)
        {
            _services.DeleteBookInformation(bookModel);
            return RedirectToAction(nameof(Start));
        }

        public IActionResult Update(Volumeinfo bookModel)
        {
            _services.UpdateBookInformation(bookModel);
            return RedirectToAction(nameof(Start));
        }
    }
}
