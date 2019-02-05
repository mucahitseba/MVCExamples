using MVC_Examples.DAL.MyEntities;
using MVC_Examples.DAL.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Examples.BLL
{
    public class UserService
    {
        UserRepository _userRepository;
        public UserService()
        {
            _userRepository = new UserRepository();
        }
        public int AddUser(User item)
        {
            return _userRepository.AddItem(item);
        }
    }
}
