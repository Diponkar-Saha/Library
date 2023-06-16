using Application.Features.Training.Services;
using Infrastructure;
using Library.Domain.Entity;
using Microsoft.AspNetCore.Cors.Infrastructure;

namespace Library.Web.Areas.Admin.Models
{
    public class BookListModel
    {
        private readonly IBookService _bookService;

        public BookListModel()
        {
        }

        public BookListModel(IBookService bookService)
        {
            _bookService = bookService;
        }

        public IList<Book> GetPopularBooks()
        {
            return _bookService.GetBooks();
        }

        public async Task<object> GetPagedBooksAsync(DataTablesAjaxRequestUtility dataTablesUtility)
        {
            var data = await _bookService.GetPagedBooksAsync(
                dataTablesUtility.PageIndex,
                dataTablesUtility.PageSize,
                dataTablesUtility.SearchText,
                dataTablesUtility.GetSortText(new string[] { "Name", "pages" }));

            return new
            {
                recordsTotal = data.total,
                recordsFiltered = data.totalDisplay,
                data = (from record in data.records
                        select new string[]
                        {
                                record.Name,
                                record.Pages.ToString(),
                                record.Id.ToString()
                        }
                    ).ToArray()
            };
        }

        internal void DeleteBook(Guid id)
        {
            _bookService.DeleteBook(id);
        }
    }

}
