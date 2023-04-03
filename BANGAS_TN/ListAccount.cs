using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANGAS_TN
{
   public class ListAccount
    {
        //khi thao tác với các thuộc tính có trong ListAccount thì sẽ thông qua instance này -> hạn chế lỗi
        private static ListAccount instance;
        public static ListAccount Instance
        {
            get
            {
                if (instance == null)
                    instance = new ListAccount();
                return instance;
            }
            set => instance = value;
        }

        List<TaiKhoan> listtaikhoan;

        public List<TaiKhoan> Listtaikhoan { get => listtaikhoan; set => listtaikhoan = value; }

        ListAccount()
        {
            listtaikhoan = new List<TaiKhoan>();
            listtaikhoan.Add(new TaiKhoan("admin1", "admin1"));
            listtaikhoan.Add(new TaiKhoan("admin2", "admin2"));
            listtaikhoan.Add(new TaiKhoan("admin3", "admin3"));
        }
    }
}
