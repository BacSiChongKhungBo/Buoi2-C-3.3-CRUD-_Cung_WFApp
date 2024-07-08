using Buoi2_C_3._3__CRUD__Cung_WFApp.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2_C_3._3__CRUD__Cung_WFApp.BUL
{
    internal class Controller
    {
        //Controller lấy dữ liệu từ service
        Service services;
        public Controller() 
        {
            services = new Service();
        }

        //Lấy danh sách từ DB
        public List<Sach> GetData()
        {
            return services.getAll();
            //Chỉ việc gọi hàm lấy danh sách bên services
        }
        //Thêm
        public string Themsach(Sach s)

        {
            if(services.AddSachToDB(s) ==true)
            {
                //Gọi service kiểm tra xem đối tượng add được hay không
                return "Thêm thành công";
            }
            return "Thêm thất bại";
        }
        public string XoaSach(Sach a)
        {
            if (services.RemoveSachToDB(a))
            {
                return "Xoas thành công";
            }
            return "Xóa thất bại";
           
        }
        public string SuaSach(Sach a)
        {
            if (services.UpdateSachToDB(a))
            {
                return "Sửa thành công";
            }
            return "Sửa thất bại";

        }

        internal List<Sach> LoadViewDataSearch(string text)
        {
            //2TH : nếu ko search và có search
            if(!string.IsNullOrEmpty(text)) 
            {
                return GetData().Where(x=> x.Ten.ToLower().Contains(text.ToLower())).ToList();
            }
            return GetData();
        }
    }
}
