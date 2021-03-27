using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class UserInfor
    {
        private int id;
        private String username;
        private String password;
        private String email;
        private DateTime create_time;

        public int Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
        public DateTime Create_time { get => create_time; set => create_time = value; }
    }
}