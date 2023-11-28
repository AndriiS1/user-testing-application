﻿using Domain.Services;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Domain.Dto;
using Microsoft.AspNetCore.Authorization;
using Domain.Models;

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
        [Route("test")]
        public IActionResult GetTestController(long testId)
        {
            var tests = _unitOfWork.Tests.SingleOrDefault(t => t.Id == testId);
            return Ok(tests);
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("questions-with-answers")]
        public IActionResult GetQuestionsWithAnswersController(long? testId)
        {
            if (testId != null)
            {
                var questions = _unitOfWork.Tests.GetQuestionsWithAnswers(testId).ToList();
                return Ok(questions);
            }
            return NotFound("Test with this id not found.");
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("get-mark")]
        public IActionResult GetMark(IEnumerable<QuestionAnswer> userAnswers)
        {
            double answersCount = userAnswers.Count();
            double correctAnswersCount = userAnswers.Count(a => a.IsCorrect == true);
            double result = Math.Round(correctAnswersCount / answersCount, 1);
            return Ok(result);
        }
    }
}
