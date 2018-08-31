using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ecoaprender.app.domain.User.Dtos;
using ecoaprender.app.domain.User.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ecoaprender.app.webapi.Controllers {
    
    [Route ("api/user")]
    public class UserController : Controller {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        [Route ("login/{email}/{password}")]
        public UserLoginResponse Login (string email, string password) {
            UserLoginRequest userLoginRequest = new UserLoginRequest {
                Email = email,
                Password = password
            };

            UserLoginResponse userLoginResponse = _userService.Login(userLoginRequest);

            return userLoginResponse;
        }
    }
}