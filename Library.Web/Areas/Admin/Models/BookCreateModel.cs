using Application.Features.Training.Services;
using Autofac;
using Microsoft.AspNetCore.Cors.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace Library.Web.Areas.Admin.Models
{
    public class BookCreateModel
    {

        [Required]
        public string Name { get; set; }
        [Required, Range(0, 100, ErrorMessage = "Pages should be between 0 & 100")]
        public int Pages { get; set; }

        private IBookService _bookService;

        public BookCreateModel()
        {

        }

        public BookCreateModel(IBookService bookService)
        {
            _bookService = bookService;
        }

        internal void ResolveDependency(ILifetimeScope scope)
        {
            _bookService = scope.Resolve<IBookService>();
        }

        internal void CreateBook()
        {
            if (!string.IsNullOrWhiteSpace(Name)
                && Pages >= 0)
            {
                _bookService.CreateBook(Name, Pages);
            }
        }
    }
}