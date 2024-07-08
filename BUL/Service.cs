using Buoi2_C_3._3__CRUD__Cung_WFApp.Context;
using Buoi2_C_3._3__CRUD__Cung_WFApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2_C_3._3__CRUD__Cung_WFApp.BUL
{
    internal class Service
    {
        //Muốn sử dụng DB, thì phải gọi DBcontext đã scaffold 
        //MyDBContext context = new MyDBContext();
        Net103QuanlysachContext context;

        //Khởi tạo ctor: ctor + tab
        public Service()
        {
            context = new Net103QuanlysachContext();
        }
        // Vì service chit gửi dữ liệu truyền kết quả
        // => phần lớn các hàm ở đay sẽ trả về bool

        //Quan trọng nhất: Lấy ra toàn bộ danh sách của bảng DB
        public List<Sach> getAll()
        {
            return context.Saches.ToList();
            //tương đương select* from Sach
        }
        // ****************Thêm đói tượng mới vào table trong DB
        public bool AddSachToDB(Sach s)
        {
            //Nếu đối tượng null => không cho add vào db
            if (s == null)
            {
                return false; //từ chối
                              // =>thêm vào DB và trả về thành công
            }
            context.Saches.Add(s);
            //lưu thay dổi
            context.SaveChanges();   //không có dòng này thì DB không thay đổihhhhhhhhhhhhhhhhhhhhhhhhh
            return true;
        }
        //*******************Sửa đối tượng
        public bool UpdateSachToDB(Sach s)
        {
            //Nếu đối tượng null => không cho add vào db
            if (s == null)
            {
                return false; //từ chối
                              // =>thêm vào DB và trả về thành công
            }
            context.Saches.Update(s);
            //lưu thay dổi
            context.SaveChanges();   //không có dòng này thì DB không thay đổi
            return true;
        }
          //*****************Xóa đối tượng
         public bool RemoveSachToDB(Sach s)
            {
                //Nếu đối tượng null => không cho add vào db
                if (s == null)
                {
                    return false; //từ chối
                                  // =>thêm vào DB và trả về thành công
                }
                context.Saches.Remove(s);
                //lưu thay dổi
                context.SaveChanges();   //không có dòng này thì DB không thay đổi
                return true;
            }
        
       /* public string DeleteBookById(int id)
        {
            var sach = context.Saches.SingleOrDefault(s => s.Id == id);

            if (sach != null)
            {
                context.Saches.Remove(sach);
                context.SaveChanges();
                return "Xóa thành công";
            }
            else
            {
                return "Không tìm thấy sách!";
            }
            
        }*/

    }
}
