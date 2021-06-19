using Business.Abstract;
using Business.Utilities;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AuthManager : IAuthService
    {
        private IAdminService _adminService;

        public bool Login(UserForLoginDto userForLoginDto)
        {
            var userToCheck = _adminService.GetByUsername(userForLoginDto.UserName);
            if (userToCheck == null)
            {
                return false;
            }

            //if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, userToCheck.AdminPasswordHash, userToCheck.AdminPasswordSalt))
            //{
            //    return false;
            //}

            return true;
        }

        public void Register(UserForRegisterDto userForRegisterDto, string password)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
            var admin = new Admin
            {
                 AdminUserName = userForRegisterDto.UserName,
               AdminPassword=userForRegisterDto.Password,
                //AdminPasswordHash = passwordHash,
                //AdminPasswordSalt = passwordSalt,
                AdminRole = "A"
            };
            _adminService.Add(admin);
            return;
        }
    }
}
