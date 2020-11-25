using System.Collections.Generic;
using System.Linq;
using YOTD.Models;

namespace YOTD.DataAccess
{
    public class QuoteRepository
    {
        private readonly QuoteDbContext _context;

        public QuoteRepository(QuoteDbContext context)
        {
            this._context = context;
        }

        public List<Quote> Get()
        {
            return this._context.Quotes.ToList();
        }

        public bool Add(Quote quote)
        {
            this._context.Quotes.Add(quote);
            var count = this._context.SaveChanges();
            return count > 0;
        }

        //Se omiten los otros CRUD
    }
}