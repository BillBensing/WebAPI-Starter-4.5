﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Components.User;
using WebAPI.Core;

namespace WebAPI.Component.User.Service
{
    public class UserService : Service<Components.User.User>, IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserRepository _userRepository;

        /// <summary>
        /// Defalut constructor for dependency injection
        /// </summary>
        /// <param name="userRepository">An object which implemenents an IUserRepository</param>
       public UserService(IUnitOfWork unitOfWork, IUserRepository userRepository)
            : base(unitOfWork, userRepository)
        {
            _unitOfWork = unitOfWork;
            _userRepository = userRepository;
        }

        public Components.User.User FindById(int id)
        {
            return _userRepository.GetById(id);
        }
    }
}