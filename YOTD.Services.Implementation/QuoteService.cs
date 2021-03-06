using System;
using System.Collections.Generic;
using YOTD.Models;
using YOTD.DataAccess;
using YOTD.Services.Contracts;
using System.Linq;

namespace YOTD.Services.Implementation
{
    public class QuoteService : IQuoteService
    {
        private readonly IRepository<Quote> _repository;
        public QuoteService(IRepository<Quote> repository)
        {
            this._repository = repository;
        }
        public Quote Get()
        {
            return GetByDate(DateTime.Now);
        }

        public Quote GetByDate(DateTime day)
        {
            return _repository.Find(x => x.Date.Equals(day)).FirstOrDefault();
        }

        public Quote GetRandom()
        {
            Random rnd = new Random();
            int r = rnd.Next(_repository.GetAll().ToList().Count);
            return _repository.GetAll().ToList()[r];
        }

        public List<Quote> GetAll()
        {
            return _repository.GetAll().ToList();
        }
        public List<Quote> GetByWeek()
        {
            DateTime firstDay;
            DateTime lastDay;
            var culture = System.Threading.Thread.CurrentThread.CurrentCulture;
            var diff = DateTime.Now.DayOfWeek - culture.DateTimeFormat.FirstDayOfWeek;

            if (diff < 0)
            {
                diff += 7;
            }
            firstDay = DateTime.Now.AddDays(-diff).Date;
            lastDay = firstDay.AddDays(6);
            
            return _repository.Find(x => x.Date >= firstDay && x.Date <= lastDay)
                                .ToList();
        }
    }
}