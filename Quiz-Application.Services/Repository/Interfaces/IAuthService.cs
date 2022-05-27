using DataAccess.Dtos.Concrete;
using Quiz_Application.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAuthService
    {
        public Task<bool> Login(LoginDto loginDto);
        public Task<bool> Register(RegisterDto registerDto);
        public Task LogOut();
    }
}
