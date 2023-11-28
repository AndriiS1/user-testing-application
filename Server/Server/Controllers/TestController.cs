using Domain;
using Domain.Dto;
using Domain.Models;
using Domain.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace ServerPesentation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IJwtService _jwtService;
        private readonly IHashService _hashService;
        private readonly IValidationService _validationService;
        private readonly IConfiguration _config;

        public TestController(IUnitOfWork unitOfWork, IJwtService jwtService, IHashService hashService, IValidationService validationService, IConfiguration config)
        {
            _unitOfWork = unitOfWork;
            _jwtService = jwtService;
            _hashService = hashService;
            _validationService = validationService;
            _config = config;
        }


        [Authorize]
        [HttpGet]
        [Route("tests")]
        public IActionResult GetTestsController()
        {
            var tests = _unitOfWork.Tests.GetAll().ToList();
            return Ok(tests);
        }

        [Authorize]
        [HttpGet]
        [Route("test")]
        public IActionResult GetTestController(long testId)
        {
            var tests = _unitOfWork.Tests.SingleOrDefault(t => t.Id == testId);
            return Ok(tests);
        }

        [Authorize]
        [HttpGet]
        [Route("questions-with-answers")]
        public IActionResult GetQuestionsWithAnswersController(long? testId)
        {
            if (testId != null)
            {
                var questions = _unitOfWork.Tests.GetQuestionsWithAnswers(testId).ToList();
                var questionsWithoutIsCorrectAttribure = questions.Select(q => new
                {
                    id = q.Id,
                    title = q.Title,
                    testId = q.TestId,
                    answers = q.Answers.Select(a => new
                    {
                        a.Id,
                        a.Title,
                        a.TestQuestionId
                    })
                });
                return Ok(questionsWithoutIsCorrectAttribure);
            }
            return NotFound("Test with this id not found.");
        }

        [Authorize]
        [HttpPost]
        [Route("get-mark")]
        public IActionResult GetMark(IEnumerable<QuestionAnswer> userAnswers)
        {
            double answersCount = userAnswers.Count();
            List<QuestionAnswer>? answersWithIsCorrectAtribute = new List<QuestionAnswer>();
            foreach (QuestionAnswer userAnswer in userAnswers)
            {
                answersWithIsCorrectAtribute.Add(_unitOfWork.Answers.Single(a => a.Id == userAnswer.Id));
            }
            var correctAnswersCount = answersWithIsCorrectAtribute.Count(a => a.IsCorrect == true);
            double result = Math.Round(correctAnswersCount / answersCount, 1);
            return Ok(result);
        }

        [Authorize]
        [HttpPost]
        [Route("test-passed")]
        public IActionResult TestPassed(TestPassedDto passedData)
        {
            var claimsIdentity = User.Identity as ClaimsIdentity;
            if (claimsIdentity != null)
            {
                var userId = long.Parse(claimsIdentity.FindFirst(ClaimTypes.NameIdentifier)?.Value);
                PassedTestData testData = new PassedTestData() { Mark = passedData.Mark, UserId = userId, TestId = passedData.TestId };
                _unitOfWork.PassedTestDatas.Add(testData);
                _unitOfWork.Complete();
                return Ok();
            }
            return Unauthorized();
        }
    }
}
