using System.Configuration;
using WiscoApplication.Data;

namespace WiscoApplication
{
    public class DataAccessForm
    {
        private readonly UserRepository _userRepository;

        public DataAccessForm()
        {
            _userRepository = new UserRepository(ConfigurationManager.ConnectionStrings["MyAppConnectionString"].ConnectionString);
        }

        public void RegisterUser(string username, string email, string password)
        {
            _userRepository.RegisterUser(username, email, password);
        }

        public bool LoginUser(string usernameOrEmail, string password)
        {
            return _userRepository.LoginUser(usernameOrEmail, password);
        }
    }
}