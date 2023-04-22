namespace SkillCheck_BE_DTOs_Audits.AuditSumary
{
    public class AuditSummaryDto
    {
        /* public int MustToHaveCount { get; set; }
         public int GoodToHaveCount { get; set; }
         public int OverallCount { get; set; }*/


        public int TotalMustHave { get; set; }
        public int TotalGoodToHave { get; set; }
        public int TotalOverall { get; set; }
        public int UserMustHave { get; set; }
        public int UserGoodToHave { get; set; }
        public int UserOverall { get; set; }
    }
}
