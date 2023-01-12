using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using RoleJWT.Data;
using RoleJWT.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;

namespace RoleJWT.Controllers
{
    /// <summary>
    /// This section is for Authentication and Authorization
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        public static User user = new User();
        private readonly IConfiguration _configuration;
        private readonly ApplicationDBContext _context;
        public AuthController(IConfiguration configuration, ApplicationDBContext context)
        {
            _configuration = configuration;
            _context = context;
        }
        /// <summary>
        /// This section for Login
        /// </summary>
        [HttpPost("Login")]
        public async Task<ActionResult<User>> Login(Login model)
        {
            var data = _context.User.Where(e => e.UserName == model.UserName).SingleOrDefault();
            if (data == null) return BadRequest("Invalid Username!");
            if (!VerifyPasswordHash(model.Password, data.PasswordHash, data.PasswordSalt))
            {
                return BadRequest("Wrong Password!");
            }
            string token = CreateToken(data);
            return Ok(token);
        }

        /// <summary>
        /// This section is for Registration
        /// </summary>

        [HttpPost("Register")]
        public async Task<ActionResult<User>> Register(Register model)
        {
            GeneratePasswordHash(model.Password, out byte[] passwordHash, out byte[] passwordSalt);
            user.UserName = model.UserName;
            user.Email = model.Email;
            user.Role = model.Role;
            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;
            _context.User.Add(user);
            await _context.SaveChangesAsync();
            return Ok("Registration Successful!");
        }

        private void GeneratePasswordHash (string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
        private bool VerifyPasswordHash (string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return computedHash.SequenceEqual(passwordHash);
            }
        }

        private string CreateToken(User user)
        {
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.Role, user.Role)
            };
            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(
                _configuration.GetSection("AppSettings:Token").Value));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddDays(7),
                signingCredentials: creds);

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return jwt;
        }
    }
}
