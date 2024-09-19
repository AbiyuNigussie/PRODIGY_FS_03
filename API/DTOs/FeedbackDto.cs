namespace API.DTOs
{
    public class FeedbackDto
    {
        public int Satisfaction { get; set; }
        public int FreshnessQuality { get; set; }
        public bool Cakes { get; set; }
        public bool Pastries { get; set; }
        public bool MiniCakes { get; set; }
        public string AdditionalComments { get; set; }
        public int LikelihoodToVisitAgain { get; set; }
    }
}