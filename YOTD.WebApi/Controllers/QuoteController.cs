using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using YOTD.Models;
using YOTD.Services.Contracts;


namespace YOTD.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuoteController : ControllerBase
    {
        private readonly IQuoteService _quoteService;
        public QuoteController(IQuoteService quoteService)
        {
            _quoteService=quoteService;
        }

        [HttpGet]
        public IEnumerable<Quote> GetQuotes()
        {
            return this._quoteService.GetAll();
        }

        [HttpGet]
        [Route("random")]
        public Quote GetRandomQuote()
        {
            return this._quoteService.GetRandom();
        }

        [HttpGet]
        [Route("today")]
        public Quote GetTodayQuote()
        {
            DateTime today=DateTime.Now.Date;
            return this._quoteService.GetByDate(today);
        }

        [HttpGet]
        [Route("week")]
        public IEnumerable<Quote> GetWeekQuotes()
        {
            var culture = System.Threading.Thread.CurrentThread.CurrentCulture;
            var diff = DateTime.Now.DayOfWeek - culture.DateTimeFormat.FirstDayOfWeek;

            if (diff < 0)
            {
                diff += 7;
            }
            var firstDay = DateTime.Now.AddDays(-diff).Date;
            var lastDay = firstDay.AddDays(6);

            return this._quoteService.GetByWeek(firstDay, lastDay);
        }

        [HttpGet]
        [Route("all")]
        public IEnumerable<Quote> GetAllQuotes()
        {
            return this._quoteService.GetAll();
        }
    }
}