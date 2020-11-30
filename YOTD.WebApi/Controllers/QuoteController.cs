using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
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
            return this._quoteService.GetByWeek();
        }

        [HttpGet]
        [Route("all")]
        public IEnumerable<Quote> GetAllQuotes()
        {
            return this._quoteService.GetAll();
        }
    }
}