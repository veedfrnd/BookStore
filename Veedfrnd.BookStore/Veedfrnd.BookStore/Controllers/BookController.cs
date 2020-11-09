using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Veedfrnd.BookStore.Models;
using Veedfrnd.BookStore.Repository;

namespace Veedfrnd.BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository;

        public BookController()
        {
            _bookRepository = new BookRepository();
        }

        public List<BookModel> Index()
        {
            return _bookRepository.getAllBooks();
        }

        public BookModel getBook(int id) {
            return _bookRepository.getBookByID(id);
        }

        public List<BookModel> searchBook(string title="", string author="") {
            return _bookRepository.searchBook(title,author);
        }

    }
}
