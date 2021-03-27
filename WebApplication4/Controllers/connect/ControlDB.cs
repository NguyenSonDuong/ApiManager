using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication4.Models;

namespace WebApplication4.Controllers.connect
{
    public class ControlDB
    {
        public MySqlConnection mySql;
        public void Connect()
        {
            try
            {
                mySql = DBConnect.GetDBConnect(ConstInforConnectDB.database);
                mySql.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Excute(String query)
        {
            try
            {
                MySqlCommand mySqlCommand = mySql.CreateCommand();
                mySqlCommand.CommandText = query;
                mySqlCommand.ExecuteNonQuery();
            }catch(Exception ex)
            {
                throw ex;
            }
        }
        public MySqlDataReader ExcuteQuery(String query)
        {
            try
            {
                MySqlCommand mySqlCommand = mySql.CreateCommand();
                mySqlCommand.CommandText = query;
                return mySqlCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}