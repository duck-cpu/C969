using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C969.Models;
using C969.Repositories;

namespace C969.Services
{
    public class AuthService
    {
        private readonly UserRepository _repo = new UserRepository();

        public User Login(string username,  string password)
        {
            return _repo.GetByCredentials(username, password);
        }
    }
}
