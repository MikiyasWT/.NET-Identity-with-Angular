using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityProjectBackend.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace IdentityProjectBackend.Controllers
{
    [ApiController]
    public class ApplicationUserController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        //private readonly SignInManager<ApplicationUser> _signInManager;

        public ApplicationUserController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            //_signInManager = signinManager;
        }

        [HttpPost]
        [Route("register")]
        public async Task<Object> PostApplicationUser(ApplicationUserModel model){

            var applicationUser = new ApplicationUser(){
                UserName = model.UserName,
                Email = model.Email,
                FullName = model.FullName
            };

            try
            {
                var result = await _userManager.CreateAsync(applicationUser,model.Password);
                return Ok(result);
            }
            catch (System.Exception)
            {
                
                throw;
            }



        }
    }
}