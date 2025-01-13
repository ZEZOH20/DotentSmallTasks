using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.src.Models;
using Microsoft.AspNetCore.Mvc;

namespace back.src.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        [HttpPost]
        [Route("create")]
        public IActionResult Create(User user)
        {
            return Ok($@" I am Server don't forget me , UserName : {user.name}  UserEmail : {user.email} ");
        }
    }
}