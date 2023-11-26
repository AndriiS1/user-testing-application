using Domain;
using Domain.Models;
using Domain.Repositories;
using Domain.Services;
using Infrastructure.DataBase;
using Infrastructure.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ServerPesentation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegistrationController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IJwtService _jwtService;
        private readonly IHashService _hashService;
        private readonly IValidationService _validationService;

        public RegistrationController(IUnitOfWork unitOfWork, IJwtService jwtService, IHashService hashService, IValidationService validationService)
        {
            _unitOfWork = unitOfWork;
            _jwtService = jwtService;
            _hashService = hashService;
            _validationService = validationService;
        }

        [HttpPost(Name = "Register")]
        [AllowAnonymous]
        public ActionResult Register(User user)
        {
            if (_validationService.UserIsValid(user))
            {
                user.Password = _hashService.getHash(user.Password ?? "");
                _unitOfWork.Users.Add(user);
                _unitOfWork.Complete();
                var tokenString = _jwtService.GenerateJSONWebToken(user);
                return Ok(new { token = tokenString });
            }
            else
            {
                return BadRequest("User data is not valid.");
            }
        }
    }
}
