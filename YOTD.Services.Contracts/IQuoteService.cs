namespace YOTD.Services.Contracts
{
    using System;
    using YOTD.Models;
    using System.Collections.Generic;
    public interface IQuoteService
    {
        Quote Get();
        List<Quote> GetAll();
        Quote GetRandom();
        Quote GetByDate(DateTime day);
        List<Quote> GetByWeek();
    }
}