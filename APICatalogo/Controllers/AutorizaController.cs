using APICatalogo.DTOs;
using APICatalogo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace APICatalogo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorizaController : ControllerBase
    {
        private readonly UserManager<Cliente> _userManager;
        private readonly SignInManager<Cliente> _signInManager;

        public AutorizaController(UserManager<Cliente> userManager,
            SignInManager<Cliente> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Autoriza Controller :: acessado em: "
                + DateTime.Now.ToLongDateString();
        }
        [HttpPost("Register")]
        public async Task<ActionResult> RegisterUser([FromBody] UsuarioDTO model)
        {
            var user = new Cliente
            {
                UserName = model.Name,
                Email = model.Email,
                EmailConfirmed = true,
                Idade = model.Idade
            };
            if(model.Password != model.CorfirmPassword)
            {
                ModelState.AddModelError(string.Empty, "As senhas não coincidem.");
                return BadRequest(ModelState);
            }

            var result = await _userManager.CreateAsync(user, model.Password);

            if (!result.Succeeded)
            {
                return BadRequest(result.Errors);
            }
            await _signInManager.SignInAsync(user, false);
            return Ok();
        }
        [HttpPost("login")]
        public async Task<ActionResult> Login([FromBody] UsuarioDTO userInfo)
        {
            var result = await _signInManager.PasswordSignInAsync(userInfo.Email, userInfo.Password,
                isPersistent: false, lockoutOnFailure: false);
            if (result.Succeeded)
            {
                return Ok();
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Login inválido...");
                return BadRequest(ModelState);
            }
        }
    }
}
