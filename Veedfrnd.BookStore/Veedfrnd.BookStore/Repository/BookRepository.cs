using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Veedfrnd.BookStore.Models;

namespace Veedfrnd.BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> getAllBooks() {
            return bookDataSource();
        }

        public BookModel getBookByID(int id) {
            return bookDataSource().Where(x => x.id == id).FirstOrDefault();
        }

        public List<BookModel> searchBook(string title = "",string author="") {
            return bookDataSource().Where(x => x.title.Contains(title) || x.author.Contains(author)).ToList();
        }

        private List<BookModel> bookDataSource() {
            return new List<BookModel>() {
                new BookModel(){id =1,title = "Dot net Core",author = "Micro Soft"},
                new BookModel(){id =2,title = "MVC",author = "Micro Soft"},
                new BookModel(){id =3,title = "Java",author = "Oracle Team"},
                new BookModel(){id =4,title = "Oracle",author = "Oracle Team"},
                new BookModel(){id =5,title = "Android",author = "Google Team"}
            };
        }
    }
}
