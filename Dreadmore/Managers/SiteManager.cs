using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dreadmore;
using Dreadmore.DTOModels;

namespace Dreodmare.Managers
{
    public class SiteManager
    {
        DMDB db = new DMDB();
        public Quotes GetQuote()
        {
            List<quote_Quote> list = db.quote_Quote.ToList();
            int n = list.Count;
            Random rnd = new Random();
            int i = rnd.Next(0, n);
            quote_Quote dbQuote = list[i];

            Quotes quote = new Quotes()
            {
                Quote = dbQuote.Quote,
                QuoteBy = dbQuote.QuoteBy,
                QuoteByImage = dbQuote.QuoteByImage
            };

            return quote;
        }

    }
}