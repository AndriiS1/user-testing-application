using Domain;
using Domain.Models;
using Domain.Services;
using Infrastructure.DataBase;
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

        public RegistrationController(IUnitOfWork unitOfWork, IJwtService jwtService, IHashService hashService)
        {
            _unitOfWork = unitOfWork;
            _jwtService = jwtService;
            _hashService = hashService;
        }

        [HttpPost(Name = "Register")]
        [AllowAnonymous]
        public async Task<ActionResult> Register(User user)
        {
            user.Password = _hashService.getHash(user.Password);
            _unitOfWork.Users.Add(user);
            _unitOfWork.Complete();
            var tokenString = _jwtService.GenerateJSONWebToken(user);
            return Ok(new { token = tokenString });
        }
    }
}
