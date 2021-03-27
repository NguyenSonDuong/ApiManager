using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication4.Models;

namespace WebApplication4.Controllers.connect
{
    public class ExcuteDB
    {
        public ControlDB controlDB;

        public String table = "user_infor";


        public ExcuteDB()
        {
            controlDB = new ControlDB();
            controlDB.Connect();
        }

        public List<UserInfor> GetALl()
        {
            List<UserInfor> users = new List<UserInfor>();
            MySqlDataReader sqls = controlDB.ExcuteQuery($"SELECT * FROM {table}");
            while (true)
            {
                UserInfor user = new UserInfor();
                user.Id = sqls.GetInt16(0);
                user.Username = sqls.GetString(1);
                user.Password = sqls.GetString(2);
                user.Email = sqls.GetString(3);
                user.Create_time = sqls.GetDateTime(4);
                users.Add(user);
                if (!sqls.NextResult())
                    break;
            }
            return users;
        }

        public UserInfor GetUserByID(String id)
        {
            MySqlDataReader sqls = controlDB.ExcuteQuery($"SELECT * FROM {table} WHERE id = {id}");
            while (true)
            {
                UserInfor user = new UserInfor();
                user.Id = sqls.GetInt16(0);
                user.Username = sqls.GetString(1);
                user.Password = sqls.GetString(2);
                user.Email = sqls.GetString(3);
                user.Create_time = sqls.GetDateTime(4);
                return user;
            }
            return null;

        }
    }
}