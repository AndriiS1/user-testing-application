using Domain.Repositories;
using Domain.Services;
using Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Domain.Dto;

namespace ServerPesentation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthenticationController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IJwtService _jwtService;
        private readonly IHashService _hashService;
        private readonly IValidationService _validationService;

        public AuthenticationController(IUnitOfWork unitOfWork, IJwtService jwtService, IHashService hashService, IValidationService validationService)
        {
            _unitOfWork = unitOfWork;
            _jwtService = jwtService;
            _hashService = hashService;
            _validationService = validationService;
        }

        [AllowAnonymous]
        [HttpPost(Name = "Login")]
        public IActionResult LoginController(LoginDto loginData)
        {
            IActionResult response = Unauthorized();
            var user = _unitOfWork.Users.Single(u => u.Password == _hashService.getHash(loginData.Password) && u.Email == loginData.Email);
            if (user != null)
            {
                var tokenString = _jwtService.GenerateJSONWebToken(user);
                response = Ok(new { token = tokenString });
            }
            return response;
        }
    }
}
