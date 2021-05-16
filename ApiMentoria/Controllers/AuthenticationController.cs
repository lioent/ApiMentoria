// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Authentication;
// using Microsoft.AspNetCore.Authorization;
// using Microsoft.AspNetCore.Mvc;


  
// using Microsoft.AspNetCore.Authorization;
// using Microsoft.AspNetCore.Mvc;
// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using ApiMentoria.Models;

// namespace ApiMentoria.Controllers
// {
//     [Route("api/[controller]")]
//     [ApiController]
//     public class AuthenticationController : ControllerBase
//     {
//         private readonly IAuthenticationService _authenticationService;

//         public AuthenticationController(IAuthenticationService authenticationService)
//         {
//             _authenticationService = authenticationService;
//         }

//         /// <summary>
//         /// Returns a new JWT Token
//         /// </summary>
//         /// <param name="tokenRequest"> TokenRequest data</param>
//         /// <response code="200">Returns jwt token</response>
//         /// <response code="401">Invalid credentials </response>
//         [AllowAnonymous]
//         [HttpPost]
//         public async Task<IActionResult> Post([FromBody] TokenRequest tokenRequest)
//         {
//             if (await _authenticationService.ValidateCredentialsAsync(tokenRequest.Email, tokenRequest.Password))
//             {
//                 return Ok(new
//                 {
//                     token = await _authenticationService.GenerateAuthenticationAsync(tokenRequest.Email)
//                 });
//             }

//             return Unauthorized("Credenciais inválidas...");
//         }
//     }
// }
