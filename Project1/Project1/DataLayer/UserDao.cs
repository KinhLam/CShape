using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.DataLayer
{
    public class UserDao
    {
        private List<User> users;
        public List<User> Users { get { return users; } set { users = value; } }
        Database database;//khai báo
        public UserDao()
        {
            users = new List<User>() {
                new User()
                {
                    ID=1,TaiKhoan="admin", MatKhau="admin",HoVaTen="Lâm Đức Kính",NhoMatKhau=true
                },
                new User()
                {
                    ID=2,TaiKhoan="user01", MatKhau="123456",HoVaTen="Hello World",NhoMatKhau=false
                }
            };
        }

        public UserDao(ref string err, string path)
        {
            users = new List<User>();
            database = new Database(path);
            users = database.ReadUsers(ref err);
        }

        public bool WriterUser(ref string err, List<User> users)
        {
            return database.WriterUser(ref err, users);
        }
        public bool WriterUser(ref string err)
        {
            return database.WriterUser(ref err, users);
        }
    }
}
