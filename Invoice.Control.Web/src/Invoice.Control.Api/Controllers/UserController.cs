using Invoice.Control.Api.Configurations;
using Invoice.Control.Api.Models;
using Invoice.Control.Api.Requests;
using Invoice.Control.Infrastructure.Repositories.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace Invoice.Control.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        private readonly TokenConfiguration _tokenConfiguration;
        public UserController(SignInManager<User> signInManager, UserManager<User> userManager, IOptions<TokenConfiguration> tokenConfiguration)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _tokenConfiguration = tokenConfiguration.Value;
        }

        [HttpPost]
        public async Task<IActionResult> RegisterUser(UserRequestModel user)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.Values.SelectMany(e => e.Errors));

            var newUser = new User
            {
                UserName = user.Email,
                Email = user.Email,
                Cnpj = user.Cnpj,
                FullName = user.FullName,
                PhoneNumber = user.Phone,
                Password = user.Password,
                PhoneNumberConfirmed = true,
                EmailConfirmed = true
            };

            var result = await _userManager.CreateAsync(newUser, newUser.Password);

            if (!result.Succeeded) return BadRequest(result.Errors);

            await _signInManager.SignInAsync(newUser, false);

            return Ok(await GenerateJwt(user.Email));
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginRequestModel login)
        {
            if (!ModelState.IsValid)    
                return BadRequest(ModelState.Values.SelectMany(e => e.Errors));

            var result = await _signInManager.PasswordSignInAsync(login.Email, login.Password, false, true);

            if (!result.Succeeded) return BadRequest("User or password is invalid");

            return Ok(await GenerateJwt(login.Email));
        }

        private async Task<string> GenerateJwt(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            var tokenHandler = new JwtSecurityTokenHandler();
            var secret = Encoding.ASCII.GetBytes(_tokenConfiguration.Secret);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Issuer = _tokenConfiguration.Issuer,
                Audience = _tokenConfiguration.ValidAt,
                Expires = DateTime.UtcNow.AddHours(_tokenConfiguration.ExpirationInHours),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(secret), SecurityAlgorithms.HmacSha256)
            };

            var token = tokenHandler.CreateJwtSecurityToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }
    }
}
