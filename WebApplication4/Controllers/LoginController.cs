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
        public Object Get(String id)
        {
            excute.table = "user_infor";
            UserInfor userInfor = excute.GetUserByID(id);
            if (userInfor == null)
            {
                return new Error() {
                    Status = 1,
                    Message = "ID không đúng",
                    Time = DateTime.Now
                };
            }
            return userInfor;
        }
        [HttpGet]
        public Object Get(String username,String password)
        {
            excute.table = "user_infor";
            UserInfor userInfor = excute.GetUserByUsernameAndPass(username,password);
            if (userInfor == null)
            {
                return new Error() {
                    Status = 1,
                    Message = "Tên tài khoản hoặc password không đúng",
                    Time = DateTime.Now
                };
            }
            return userInfor;
        }


    }
}
