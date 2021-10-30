using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanVeTau
{
    public class Account
    {
        public Account(string userName, string name, int type, string password = null)
        {
            this.UserName = userName;
            this.Name = name;
            this.Type = type;
            this.Password = password;
        }
        public Account(DataRow row)
        {
            this.UserName = row["UserName"].ToString();
            this.Name = row["Name"].ToString();
            this.Type = (int)row["Type"];
            this.Password = row["Password"].ToString();
        }
        private string userName;
        private string password;
        private string name;
        private int type;

        public string UserName
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }
    }
}
