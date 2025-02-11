using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TraineePro.Data;
using TraineePro.Models;

namespace TraineePro.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbcontext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbcontext application)
        {
            _logger = logger;
            _context = application;
        }

        // Default index page
        public IActionResult Index()
        {
            return RedirectToAction("Create", "TestModels");
        }

      

        // Submission confirmation page
        public IActionResult SubmissionConfirmation()
        {
            return View();
        }

        // Privacy policy page
        public IActionResult Privacy()
        {
            return View();
        }

        // General error page
        public IActionResult Erorr()
        {
            _logger.LogError("An error occurred while processing the request.");
            return View();
        }

        // Review submissions page for HR
        [HttpGet]
        public IActionResult ReviewSubmissions(string status)
        {
            try
            {
                var submissions = _context.Trainees.AsQueryable();

                if (!string.IsNullOrEmpty(status))
                {
                    submissions = submissions.Where(t => t.Status == status);
                }

                return View(submissions.ToList());
            }
            catch (Exception ex)
            {
                _logger.LogError("An error occurred while fetching submissions: {Message}", ex.Message);
                return RedirectToAction("Erorr");
            }
        }

        // Approve a trainee submission
        [HttpPost]
        public IActionResult ApproveSubmission(int id)
        {
            try
            {
                var trainee = _context.Trainees.Find(id);
                if (trainee != null)
                {
                    trainee.Status = "Approved";
                    _context.SaveChanges();
                    _logger.LogInformation("Trainee ID {TraineeID} approved successfully.", id);
                }

                return RedirectToAction("ReviewSubmissions");
            }
            catch (Exception ex)
            {
                _logger.LogError("An error occurred while approving trainee ID {TraineeID}: {Message}", id, ex.Message);
                return RedirectToAction("Erorr");
            }
        }

        // Reject a trainee submission
        [HttpPost]
        public IActionResult RejectSubmission(int id)
        {
            try
            {
                var trainee = _context.Trainees.Find(id);
                if (trainee != null)
                {
                    trainee.Status = "Rejected";
                    _context.SaveChanges();
                    _logger.LogInformation("Trainee ID {TraineeID} rejected successfully.", id);
                }

                return RedirectToAction("ReviewSubmissions");
            }
            catch (Exception ex)
            {
                _logger.LogError("An error occurred while rejecting trainee ID {TraineeID}: {Message}", id, ex.Message);
                return RedirectToAction("Erorr");
            }
        }

        // Add Supervisor Evaluation Page
        [HttpGet]
        public IActionResult AddEvaluation(int id)
        {
            var trainee = _context.Trainees.Find(id);
            if (trainee == null)
            {
                return RedirectToAction("Erorr");
            }
            return View(trainee);
        }

        [HttpPost]
        public IActionResult AddEvaluation(int id, string attendance, string finalEvaluation)
        {
            try
            {
                var trainee = _context.Trainees.Find(id);
                if (trainee != null)
                {
                  
                    trainee.Status = "Evaluated";
                    _context.SaveChanges();

                    _logger.LogInformation("Evaluation added for trainee ID {TraineeID}.", id);
                }

                return RedirectToAction("ReviewSubmissions");
            }
            catch (Exception ex)
            {
                _logger.LogError("An error occurred while adding evaluation for trainee ID {TraineeID}: {Message}", id, ex.Message);
                return RedirectToAction("Erorr");
            }
        }

        // General error handling
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
