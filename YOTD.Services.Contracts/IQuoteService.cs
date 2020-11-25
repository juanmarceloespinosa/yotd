namespace YOTD.Services.Contracts
{
    using System;
    using YOTD.Models;
    using System.Collections.Generic;
    public interface IQuoteService
    {
        Quote Get();
        Quote GetByDate(DateTime day);
        List<Quote> GetByWeek(DateTime firstDay, DateTime secondDay);
    }
}