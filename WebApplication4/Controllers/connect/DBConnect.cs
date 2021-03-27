using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication4.Models;

namespace WebApplication4.Controllers.connect
{
    public class DBConnect
    {
        public static MySqlConnection GetDBConnect(String database)
        {
            String connect = "Server=" + ConstInforConnectDB.host + ";Database=" + database + ";port=" + ConstInforConnectDB.port + ";User Id=" + ConstInforConnectDB.username + ";password=" + ConstInforConnectDB.password;
            return new MySqlConnection(connect);
        }
    }
}