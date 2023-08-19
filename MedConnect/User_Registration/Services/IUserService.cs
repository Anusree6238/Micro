using User_Registration.Models;



namespace User_Registration.Services

{

    public interface IUserService

    {

        public IEnumerable<User_Reg> GetUserList();

        public User_Reg GetUserById(int id);

        public User_Reg AddUser(User_Reg user);

        public User_Reg UpdateUser(User_Reg user);

        public bool DeleteUser(int Id);

    }

}



