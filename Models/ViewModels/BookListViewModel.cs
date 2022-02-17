using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Models.ViewModels
{
    public class BookListViewModel
    {
        public IQueryable<Books> BookList { get; set; }
        public PageInfo PageInfo { get; set; }
    }
}
