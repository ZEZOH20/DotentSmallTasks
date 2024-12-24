using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotnetTranning.src.Models;
using DotnetTranning.src.Repositorys;
using Microsoft.AspNetCore.Mvc;

namespace DotnetTranning.src.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        UserRepository _UserRepository;
        public UserController()
        {
            _UserRepository = new UserRepository();
        }

        [HttpPost]
        [Route("create")]
        public IActionResult Create(User User)
        {
            try
            {
                _UserRepository._Repository.AttachEntity(User);
            }
            catch (Exception e)
            {
                return Ok(e.Message);
            }

            return Ok(@$"User {User.Name} successfully Inserted");

        }
    }
}