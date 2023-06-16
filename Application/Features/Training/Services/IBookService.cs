using Library.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Training.Services
{
    public interface IBookService
    {
        void CreateBook(string name, int pages);
        void DeleteBook(Guid id);
        Book GetBook(Guid id);
        public IList<Book> GetBooks();
        Task<(IList<Book> records, int total, int totalDisplay)> GetPagedBooksAsync(int pageIndex,
            int pageSize, string searchText, string orderBy);
        void UpdateBook(Guid id, string name, int pages);
    }
}
