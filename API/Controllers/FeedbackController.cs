using API.Data;
using API.DTOs;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class FeedbackController : BaseApiController
    {
        private readonly StoreContext _context;

        public FeedbackController(StoreContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<Feedback>> SubmitFeedback(FeedbackDto feedbackDto)
        {
            try
            {
                var feedback = new Feedback
                {
                    Satisfaction = feedbackDto.Satisfaction,
                    FreshnessQuality = feedbackDto.FreshnessQuality,
                    Cakes = feedbackDto.Cakes,
                    Pastries = feedbackDto.Pastries,
                    MiniCakes = feedbackDto.MiniCakes,
                    AdditionalComments = feedbackDto.AdditionalComments,
                    LikelihoodToVisitAgain = feedbackDto.LikelihoodToVisitAgain
                };

                _context.Feedbacks.Add(feedback);

                await _context.SaveChangesAsync();

                return NoContent();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error submitting feedback: {ex}");

                return StatusCode(500, new ProblemDetails
                {
                    Title = "An error occurred while processing the request.",
                    Detail = ex.Message
                });
            }
        }
    }
}