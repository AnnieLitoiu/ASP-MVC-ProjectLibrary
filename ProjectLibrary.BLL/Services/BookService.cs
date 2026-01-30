using ProjectLibrary.BLL.Entities;
using ProjectLibrary.BLL.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectLibrary.BLL.Services
{
    public class BookService
    {
        private readonly DAL.Services.BookService _dalService;

        public BookService(DAL.Services.BookService dalService)
        {
            _dalService = dalService;
        }

        public IEnumerable<Book> Get()
        {
            return _dalService.Get().Select(book => book.ToBLL());
        }

        public Book Get(Guid bookId)
        {
            return _dalService.Get(bookId).ToBLL();
        }

        public Guid Create(Book entity)
        {
            return _dalService.Create(entity.ToDAL());
        }

        public void Update(Guid bookId, Book newData)
        {
            _dalService.Update(bookId, newData.ToDAL());
        }

        public void Delete(Guid bookId)
        {
            _dalService.Delete(bookId);
        }
    }
}
