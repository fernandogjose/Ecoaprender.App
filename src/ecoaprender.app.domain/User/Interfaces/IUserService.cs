using ecoaprender.app.domain.User.Dtos;

namespace ecoaprender.app.domain.User.Interfaces
{
    public interface IUserService
    {
         UserLoginResponse Login(UserLoginRequest UserLoginRequest); 
    }
}