using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dreadmore.DTOModels;

namespace Dreadmore.DTOModels
{
    public class ReviewDetails : GetReviews

    {
        public MovieDetails Movie { get; set; }
    }
}