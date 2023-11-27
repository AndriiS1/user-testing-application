﻿using Domain;
using Domain.Dto;
using Domain.Models;
using Domain.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;

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
        private readonly IConfiguration _config;

        public AuthenticationController(IUnitOfWork unitOfWork, IJwtService jwtService, IHashService hashService, IValidationService validationService, IConfiguration config)
        {
            _unitOfWork = unitOfWork;
            _jwtService = jwtService;
            _hashService = hashService;
            _validationService = validationService;
            _config = config;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("login")]
        public IActionResult LoginController(LoginDto loginData)
        {
            IActionResult response = Unauthorized();
            var user = _unitOfWork.Users.Single(u => u.Password == _hashService.getHash(loginData.Password) && u.Email == loginData.Email);
            if (user != null)
            {
                var accessToken = _jwtService.GenerateJSONWebToken(user);
                var refreshTokenDataDto = _jwtService.GenerateRefreshTokenData();
                _unitOfWork.Users.UpdateUserRefreshTokenData(user.Id, refreshTokenDataDto);
                _unitOfWork.Complete();
                response = Ok(new { accessToken = accessToken, refreshToken = refreshTokenDataDto.RefreshToken});
            }
            return response;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("register")]
        public IActionResult Register(User user)
        {
            if (_validationService.UserIsValid(user))
            {
                user.Password = _hashService.getHash(user.Password ?? "");
                _unitOfWork.Users.Add(user);
                var acessToken = _jwtService.GenerateJSONWebToken(user);
                var refreshTokenDataDto = _jwtService.GenerateRefreshTokenData();
                _unitOfWork.Users.UpdateUserRefreshTokenData(user.Id, refreshTokenDataDto);
                _unitOfWork.Complete();
                return Ok(new { acessToken = acessToken, refreshToken = refreshTokenDataDto.RefreshToken });
            }
            else
            {
                return BadRequest("User data is not valid.");
            }
        }

        [HttpPost]
        [Route("refresh-token")]
        public async Task<IActionResult> RefreshToken(TokenDto tokenData)
        {
            if (tokenData is null)
            {
                return BadRequest("Invalid client request");
            }

            string? accessToken = tokenData.AccessToken;
            string? refreshToken = tokenData.RefreshToken;

            var principal = _jwtService.GetPrincipalFromExpiredToken(accessToken);
            if (principal == null)
            {
                return BadRequest("Invalid access token or refresh token");
            }

            var sad = principal?.FindFirst(JwtRegisteredClaimNames.NameId);

            string userIdentifier = principal?.FindFirst(c=> c.Type == JwtRegisteredClaimNames.NameId).Value;

            var user = _unitOfWork.Users.Single(u => u.Id == long.Parse(userIdentifier));

            if (user == null || user.RefreshToken != refreshToken || user.RefreshTokenExpiryTime <= DateTime.Now)
            {
                return BadRequest("Invalid access token or refresh token");
            }

            var newAccessToken = _jwtService.GenerateJSONWebToken(user);
            var newRefreshTokenDataDto = _jwtService.GenerateRefreshTokenData();
            _unitOfWork.Users.UpdateUserRefreshTokenData(user.Id, newRefreshTokenDataDto);
            _unitOfWork.Complete();

            return Ok(new
            {
                accessToken = newAccessToken,
                refreshToken = newRefreshTokenDataDto.RefreshToken
            });
        }
    }
}
