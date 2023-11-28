using Domain.Services;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Domain.Dto;
using Microsoft.AspNetCore.Authorization;

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


        [AllowAnonymous]
        [HttpGet]
        [Route("tests")]
        public IActionResult GetTestsController()
        {
            var tests = _unitOfWork.Tests.GetAll().ToList();
            return Ok(tests);
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("questions-with-answers")]
        public IActionResult GetQuestionsWithAnswersController(long testId)
        {
            var questions = _unitOfWork.Tests.GetQuestionsWithAnswers(testId).ToList();
            return Ok(questions);
        }
    }
}
