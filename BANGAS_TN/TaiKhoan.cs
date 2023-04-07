using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANGAS_TN
{
   public class TaiKhoan
    {
        private string name;

        public string Name { get => name; set => name = value; }

        private string password;
        public string Password { get => password; set => password = value; }

        public TaiKhoan(string name, string password)
        {
            this.Name = name;
            this.Password = password;
        }    
    }
}
