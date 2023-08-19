using User_Registration.Data;

using User_Registration.Models;

namespace User_Registration.Services

{

    public class UserService : IUserService

    {

        private readonly DbContextClass _dbContext;

        public UserService(DbContextClass dbContext)

        {

            _dbContext = dbContext;

        }

        public IEnumerable<User_Reg> GetUserList()

        {

            return _dbContext.UserRegistrations.ToList();

        }

        public User_Reg GetUserById(int id)

        {

            return _dbContext.UserRegistrations.Where(x => x.UserId == id).FirstOrDefault();

        }

        public User_Reg AddUser(User_Reg user)

        {

            var result = _dbContext.UserRegistrations.Add(user);

            _dbContext.SaveChanges();

            return result.Entity;

        }

        public User_Reg UpdateUser(User_Reg user)

        {

            var result = _dbContext.UserRegistrations.Update(user);

            _dbContext.SaveChanges();

            return result.Entity;

        }

        public bool DeleteUser(int Id)

        {

            var filteredData = _dbContext.UserRegistrations.Where(x => x.UserId == Id).FirstOrDefault();

            var result = _dbContext.Remove(filteredData);

            _dbContext.SaveChanges();

            return result != null ? true : false;

        }

    }

}