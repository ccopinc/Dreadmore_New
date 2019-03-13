using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dreadmore;
using Dreadmore.DTOModels;

namespace Dreadmore.Managers
{
    public class SiteManager
    {
        DMDB db = new DMDB();
        public Quote GetQuote()
        {
            List<quote_Quote> list = db.quote_Quote.ToList();
            int n = list.Count;
            Random rnd = new Random();
            int i = rnd.Next(0, n);
            quote_Quote dbQuote = list[i]; 

            Quote quote = new Quote()
            {
                QuoteText = dbQuote.Quote,
                QuoteBy = dbQuote.QuoteBy,
                QuoteByImage = dbQuote.QuoteByImage
            };

            return quote;
        }

    }
}