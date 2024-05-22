using Business.Abstract;
using Core.Entities.Concreate;
using Core.Utilities.Results;
using Core.Utilities.Security.JWT;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concreate
{
    public class AuthManager : IAuthService
    {
        private IUserSercive _userService;
        private ITokenHelper _tokenHelper;

        public AuthManager(IUserSercive userSercive, ITokenHelper tokenHelper)
        {
            _userService = userSercive;
            _tokenHelper = tokenHelper;
        }

        public IDataResult<User> Login(UserForLoginDto userForLoginDto)
        {
            var userToCheck = _userService.GetByTCno(userForLoginDto.Email);
            if(userToCheck == null)
            {
                return new ErrorDataResult<User>();
            }
            return new SuccessDataResult<User>(userToCheck.Data, message:"Başarılı");
        }
    }
}
