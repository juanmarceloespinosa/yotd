using System.Collections.Generic;
using System.Linq;
using YOTD.Models;

namespace YOTD.DataAccess
{
    public class CategoryRepository
    {
        private readonly QuoteDbContext _context;

        public CategoryRepository(QuoteDbContext context)
        {
            this._context = context;
        }

        public List<Category> Get()
        {
            return this._context.Categories.ToList();
        }

        public bool Add(Category category)
        {
            this._context.Categories.Add(category);
            var count = this._context.SaveChanges();
            return count > 0;
        }

        //Se omiten los otros CRUD
    }
}