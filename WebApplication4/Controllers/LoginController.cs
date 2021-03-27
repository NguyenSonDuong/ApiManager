using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication4.Controllers.connect;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class LoginController : ApiController
    {
        public ExcuteDB excute;

        public LoginController()
        {
            excute = new ExcuteDB();
        }
        [HttpGet]
        public List<UserInfor> Get()
        {
            excute.table = "user_infor";
            return excute.GetALl();
        }

        [HttpGet]
        public UserInfor Get(String id)
        {
            excute.table = "user_infor";
            return excute.GetUserByID(id);
        }


    }
}
