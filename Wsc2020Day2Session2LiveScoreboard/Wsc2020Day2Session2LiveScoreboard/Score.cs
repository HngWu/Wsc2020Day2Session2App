//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wsc2020Day2Session2LiveScoreboard
{
    using System;
    using System.Collections.Generic;
    
    public partial class Score
    {
        public int id { get; set; }
        public string competitorId { get; set; }
        public int areaCriteriaId { get; set; }
        public string areaCompetitionId { get; set; }
        public int CompetitionSubmissionId { get; set; }
        public decimal score1 { get; set; }
    
        public virtual AreaCompetition AreaCompetition { get; set; }
        public virtual AreaCriteria AreaCriteria { get; set; }
        public virtual CompetitorSubmission CompetitorSubmission { get; set; }
        public virtual User User { get; set; }
    }
}
