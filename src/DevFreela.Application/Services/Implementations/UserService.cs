using DevFreela.Application.InputModels;
using DevFreela.Application.Services.Interfaces;
using DevFreela.Application.ViewModels;
using DevFreela.Core.Entities;
using DevFreela.Infraestructure.Persistence;
using System.Linq;

namespace DevFreela.Application.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly DevFreelaDbContext _dbContext;

        public UserService(DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public UserViewModel GetById(int id)
        {
            var user = _dbContext.Users.SingleOrDefault(x => x.Id == id);

            if (user == null)
                return null;

            var userDetailViewModel = new UserViewModel(
                user.FullName,
                user.Email);

            return userDetailViewModel;
        }

        public int Create(CreateUserInputModel inptModel)
        {
            //var user = new User(inptModel.FullName, inptModel.Email, inptModel.BirthDate);

            //_dbContext.Users.Add(user);

            //_dbContext.SaveChanges();

            return 2;
        }
    }
}
