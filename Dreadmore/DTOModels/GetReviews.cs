using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Dreadmore;

namespace Dreadmore.DTOModels
{
    public class GetReviews
    {
        ////BCC/ BEGIN CUSTOM CODE SECTION 
        ////ECC/ END CUSTOM CODE SECTION 
        public int id_Review { get; set; }
        public string IMDBID { get; set; }
        public int id_Reviewer { get; set; }
        public string Reviewer { get; set; }
        public string UserReviewCount { get; set; }
        public string MovieTitle { get; set; }
        public string ReviewTitle { get; set; }
        public string Review { get; set; }
        public int OverAllPoints { get; set; }
        public int ScriptPoints { get; set; }
        public int ActingPoints { get; set; }
        public int EffectsPoints { get; set; }
        public int SoundPoints { get; set; }
        public int TotalPoints { get; set; }

        public string ReviewDate { get; set; }
    }
}
