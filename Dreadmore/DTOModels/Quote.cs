using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Dreadmore.DTOModels.Infrastructure;
using Dreadmore;

namespace Dreadmore.DTOModels
{
    public class Quote
    {
        ////BCC/ BEGIN CUSTOM CODE SECTION 
        ////ECC/ END CUSTOM CODE SECTION 
        public int id_Quote { get; set; }
        public string QuoteText { get; set; }
        public string QuoteBy { get; set; }
        public string QuoteByImage { get; set; }
    }

    public class QuoteMapper : MapperBase<quote_Quote, Quote>
    {
        ////BCC/ BEGIN CUSTOM CODE SECTION 
        ////ECC/ END CUSTOM CODE SECTION 
        public override Expression<Func<quote_Quote, Quote>> SelectorExpression
        {
            get
            {
                return ((Expression<Func<quote_Quote, Quote>>)(p => new Quote()
                {
                    ////BCC/ BEGIN CUSTOM CODE SECTION 
                    ////ECC/ END CUSTOM CODE SECTION 
                    id_Quote = p.id_Quote,
                    QuoteText = p.Quote,
                    QuoteBy = p.QuoteBy,
                    QuoteByImage = p.QuoteByImage
                }));
            }
        }

        public override void MapToModel(Quote dto, quote_Quote model)
        {
            ////BCC/ BEGIN CUSTOM CODE SECTION 
            ////ECC/ END CUSTOM CODE SECTION 
            model.id_Quote = dto.id_Quote;
            model.Quote = dto.QuoteText;
            model.QuoteBy = dto.QuoteBy;
            model.QuoteByImage = dto.QuoteByImage;

        }
    }
}
