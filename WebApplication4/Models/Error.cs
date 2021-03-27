using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class Error
    {
        private int status;
        private String message;
        private DateTime time;

        public int Status { get => status; set => status = value; }
        public string Message { get => message; set => message = value; }
        public DateTime Time { get => time; set => time = value; }
    }
}