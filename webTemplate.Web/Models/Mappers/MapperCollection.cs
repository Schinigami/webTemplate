using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using webTemplate.Model;
using webTemplate.Web.Models.ViewModels;
using webTemplate.Web.Models.ViewModels.User;

namespace webTemplate.Web.Models.Mappers
{
    public static class MapperCollection
    {
        public static class LoginUserMapper
        {
            public static void Init()
            {
                Mapper.CreateMap<User, LoginView>();
                Mapper.CreateMap<LoginView, User>();
            }
        }

        public static class UserMapper
        {
            public static void Init()
            {
                Mapper.CreateMap<User, RegisterUserView>();
                Mapper.CreateMap<RegisterUserView, User>();

                Mapper.CreateMap<User, UserView>();
                Mapper.CreateMap<UserView, User>();
            }
        }
    }
}