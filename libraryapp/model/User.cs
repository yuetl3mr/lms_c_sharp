using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryapp
{
    public class User
    {
        public User(int uid, string name, int gender, string addr, string userLogin, string password, int role)
        {
            Uid = uid;
            Name = name;
            Gender = gender;
            Addr = addr;
            UserLogin = userLogin;
            Password = password;
            Role = role;
        }
        public User() { }
        public int Uid { get; set; }
        public string Name { get; set; }
        public string Addr { get; set; }
        public string UserLogin { get; set; }
        public string Password { get; set; }
        public int Gender { get; set; }
        public int Role {  get; set; }
    }
}
