using ecoaprender.app.domain.User.Dtos;

namespace ecoaprender.app.domain.User.Interfaces
{
    public interface IUserRepository
    {
         UserLoginResponse Login(UserLoginRequest UserLoginRequest); 
    }
}