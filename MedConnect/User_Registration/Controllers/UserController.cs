using User_Registration.Models;

using User_Registration.Services;

using Microsoft.AspNetCore.Mvc;

namespace User_Registration.Controllers

{

    [Route("api/[controller]")]

    [ApiController]

    public class UserController : ControllerBase

    {

        private readonly IUserService userService;

        public UserController(IUserService _userService)

        {

            userService = _userService;

        }

        [HttpGet]

        public IEnumerable<User_Reg> UserList()

        {

            var userList = userService.GetUserList();

            return userList;

        }

        [HttpGet("{id}")]

        public User_Reg GetUserById(int id)

        {

            return userService.GetUserById(id);

        }

        [HttpPost]

        public User_Reg AddUser(User_Reg user)

        {

            return userService.AddUser(user);

        }

        [HttpPut]

        public User_Reg UpdateUser(User_Reg user)

        {

            return userService.UpdateUser(user);

        }

        [HttpDelete("{id}")]

        public bool DeleteUser(int id)

        {

            return userService.DeleteUser(id);

        }

    }

}