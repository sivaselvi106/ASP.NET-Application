using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class User
    {
        private string UserName { get; set; }
        private string MailId { get; set; }
        private string Password { get; set; }
        private long MobNo { get; set; }
        private string State { get; set; }
        private string Country { get; set; }

        private int Age { get; set; }
        public User(string userName,string mailId,string password,long mobNo,int age,string state,string country)
        {
            this.UserName = userName;
            this.MailId = mailId;
            this.Password = password;
            this.MobNo = mobNo;
            this.Age = age;
            this.State = state;
            this.Country = country;
        }
    }
}