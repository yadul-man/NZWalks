using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NZWalks.API.CustomActionFilters;
using NZWalks.API.Models.DTO;
using NZWalks.API.Repositories;

namespace NZWalks.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly ITokenRepository tokenRepository;

        public AuthController(UserManager<IdentityUser> userManager, ITokenRepository tokenRepository)
        {
            this.userManager = userManager;
            this.tokenRepository = tokenRepository;
        }

        [HttpPost]
        [Route("Register")]
        [ValidateModel]
        public async Task<IActionResult> Register([FromBody] RegisterDTO registerDTO)
        {
            var identityUser = new IdentityUser
            {
                UserName = registerDTO.Username,
                Email = registerDTO.Username
            };

            var identityResult = await userManager.CreateAsync(identityUser, registerDTO.Password);

            if (identityResult.Succeeded)
            {
                // Add roles to the user
                if (registerDTO.Roles != null && registerDTO.Roles.Any())
                {
                    identityResult = await userManager.AddToRolesAsync(identityUser, registerDTO.Roles);

                    if (identityResult.Succeeded)
                    {
                        return Ok("User registered. Please login.");
                    }
                }
            }

            return BadRequest("Something went wrong");
        }

        [HttpPost]
        [Route("Login")]
        [ValidateModel]
        public async Task<IActionResult> Login([FromBody] LoginDTO loginDTO)
        {
            var user = await userManager.FindByEmailAsync(loginDTO.Username);

            if (user != null) 
            { 
                var checkPasswordResult = await userManager.CheckPasswordAsync(user, loginDTO.Password);
                if (checkPasswordResult)
                {
                    // Get roles for the user
                    var roles = await userManager.GetRolesAsync(user);
                    
                    if (roles != null) 
                    { 
                        // Create token
                        var jwtToken = tokenRepository.CreateJWTToken(user, roles.ToList());
                        
                        var response = new LoginResponseDTO
                        {
                            JWTToken = jwtToken
                        };

                        return Ok(response);
                    }
                }
            }

            return BadRequest("Username or password is incorrect.");
        }
    }
}
