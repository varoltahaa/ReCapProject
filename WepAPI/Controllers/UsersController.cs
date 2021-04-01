using Business.Abstract;
using Core.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WepAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("getbymail")]
        public IActionResult GetByMaill(string email)
        {
            var result = _userService.GetByMaill(email);
            if (result.Success)
            {
                return Ok(new {result.Data.Id,result.Data.FirstName,result.Data.LastName,result.Data.Email,result.Data.Status });
            }

            return BadRequest(result);

        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _userService.GetById(id);
            if (result.Success)
            {
                return Ok(new { result.Data.Id, result.Data.FirstName, result.Data.LastName, result.Data.Email, result.Data.Status });
            }

            return BadRequest(result);

        }

        [HttpPost("update")]

        public IActionResult Update(User user)
        {
            var result = _userService.Update(user);
            if (result.Success)
            {
                return Ok();
            }
            return BadRequest(result);
        }
    }
}
