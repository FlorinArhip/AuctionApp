﻿using DataMapper;
using DataMapper.PostgresDAO;
using DomainModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.ServiceImplementation
{
    public class UserServiceImpl : IUserService
    {
        private IUserDataServices userAccountDataServices;

        public UserServiceImpl(IUserDataServices userAccountDataServices)
        {
            this.userAccountDataServices = userAccountDataServices;
        }

        void ICRUDService<User>.Delete(User entity)
        {
            throw new NotImplementedException();
        }

        IList<User> ICRUDService<User>.GetAll()
        {
            return userAccountDataServices.GetAll();
        }

        void ICRUDService<User>.GetById(int id)
        {
            throw new NotImplementedException();
        }

        void ICRUDService<User>.Insert(User entity)
        {
            throw new NotImplementedException();
        }

        void ICRUDService<User>.Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
