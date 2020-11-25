using System.Collections.Generic;

namespace YOTD.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name {  get; set; }
        public IList<Quote> Quotes {get; set; }
    }
}
