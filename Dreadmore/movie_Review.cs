//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dreadmore
{
    using System;
    using System.Collections.Generic;
    
    public partial class movie_Review
    {
        public int id_Review { get; set; }
        public string IMDB_ID { get; set; }
        public int id_Reviewer { get; set; }
        public string MovieTitle { get; set; }
        public string ReviewTitle { get; set; }
        public string Review { get; set; }
        public int OverAllPoints { get; set; }
        public int ScriptPoints { get; set; }
        public int ActingPoints { get; set; }
        public int EffectsPoints { get; set; }
        public int SoundPoints { get; set; }
        public Nullable<System.DateTime> ReviewDate { get; set; }
        public int TotalScore { get; set; }
        public Nullable<bool> Approved { get; set; }
        public Nullable<int> ApprovedBy { get; set; }
        public Nullable<System.DateTime> ApprovedDate { get; set; }
    }
}
