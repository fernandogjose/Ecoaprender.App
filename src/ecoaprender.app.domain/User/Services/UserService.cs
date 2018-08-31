using ecoaprender.app.domain.User.Dtos;
using ecoaprender.app.domain.User.Interfaces;

namespace ecoaprender.app.domain.User.Services {
    public class UserService : IUserService {
        private readonly IUserRepository _userRepository;

        public UserService (IUserRepository userRepository) {
            _userRepository = userRepository;
        }

        public UserLoginResponse Login (UserLoginRequest userLoginRequest) {
            UserLoginResponse userLoginResponse = _userRepository.Login (userLoginRequest);
            return userLoginResponse;
        }
    }
}