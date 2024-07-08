using Buoi2_C_3._3__CRUD__Cung_WFApp.BUL;
using Buoi2_C_3._3__CRUD__Cung_WFApp.Models;

namespace Buoi2_C_3._3__CRUD__Cung_WFApp
{
    public partial class Form1 : Form
    {
        Controller c = new Controller(); //Cần để tương tác dữ liệu, lấy dữ liệu từ controller
        private int _idWhenClick;
        public Form1()
        {
            InitializeComponent(); //mở form
                                   //Ngay sau khi mở Form
                                   //hiển thiij dữ liệu luôn
            LoadComboBox();
            LoadViewData();
        }
        //Nếu trong TH cần load dữ liệu vào combobox
        //Ví dụ dữ liệu cứng
        private void LoadComboBox()
        {
            //Thêm dữ liệu vào combobox
            cbxNhaxuatban.Items.Add("Kim Đồng");
            cbxNhaxuatban.Items.Add("BGD");
            cbxNhaxuatban.Items.Add("Trẻ");
            //Ko cho edit combobox
            cbxNhaxuatban.DropDownStyle = ComboBoxStyle.DropDownList;
            //Chọn sẵn 1 item hiển thị lúc đầu
            cbxNhaxuatban.SelectedIndex = 0;
        }

        private void LoadViewData()
        {
            //Tạo cột
            //1. điền số lượng cột
            dtgView.ColumnCount = 5; //tương đương với thuộc tính đối tượng
            //2. đặt tên cột
            dtgView.Columns[0].Name = "Mã Sách";
            dtgView.Columns[1].Name = "Tên Sách";
            dtgView.Columns[2].Name = "Tác Giả";
            dtgView.Columns[3].Name = "Nhà Xuất Bản";
            dtgView.Columns[4].Name = "Giá Tiền";
            //3. Xử lý dòng
            //Quan trọng : Clear tất cả mỗi dòng khi load lại
            dtgView.Rows.Clear();
            //4.Thêm dữ liệu vào mỗi dòng tiếp theo
            foreach (var s in c.GetData())
            {
                dtgView.Rows.Add(s.Id, s.Ten, s.Tacgia, s.Nxb, s.Giatien);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {


            if (DialogResult.Yes == MessageBox.Show("Bạn Chắc chưa?", "Thêm đối tượng", MessageBoxButtons.YesNo))
            {
                // Cần lấy text của tất cả các trường
                // gán vào từng thuộc tính đối tượng
                Sach s = new Sach();
                s.Id = int.Parse(txtMasach.Text);
                s.Ten = txtTen.Text;
                s.Tacgia = txtTacgia.Text;
                s.Nxb = cbxNhaxuatban.Text;
                s.Giatien = int.Parse(txtGiatien.Text);
                //Controller xửa lý và hiển thị kết quả
                MessageBox.Show(c.Themsach(s));
                //Nhớ load lại data để hiển thị dữ liệu mới thêm
            }
            else
            {
                return;
            }
            LoadViewData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //lấy được sách có ID đã chọn
            Sach s = c.GetData().Where(x => x.Id == _idWhenClick).FirstOrDefault();
            //Gọi Controller xử lý và trả về kết quả
            MessageBox.Show(c.XoaSach(s));
            //Load lại data
            LoadViewData();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMasach.Text = "";
            txtTen.Text = "";
            txtTacgia.Text = "";
            txtMasach.Clear();
            cbxNhaxuatban.Text = "";
            txtGiatien.Clear();
            LoadViewData();
        }

        private void FillDataToTextBox()
        {
            //tìm sách vs ID đã có
            var sach = c.GetData().Where(x => x.Id == _idWhenClick).FirstOrDefault();
            //fill vào các textbox
            txtMasach.Text = sach.Id.ToString();
            txtTen.Text = sach.Ten.ToString();
            txtTacgia.Text = sach.Tacgia.ToString();
            cbxNhaxuatban.Text = sach.Nxb.ToString();
            txtGiatien.Text = sach.Giatien.ToString();
        }

        #region CellContentClick
        //CellContentClick: Khi click vào 1 Sách trong datagridView
        //=> sẽ nắm được Id và thông tin của đối tượng được click
        //=> Lưu được ID của đối tượng (khi có ID => có thông tin đối tượng)
        //=> có thể Sửa, Xóa đối tượng theo ý muốn
        //B1: tạo 1 biến toàn cục(global var) để lưu biến
        //B2: Ở event CellContentClick => lấy được dòng mà bản thân đang bấm vào
        //B3: Lấy cột chứa ID ở dòng đó => trích xuất nội dung 
        //B4: Lưu ID lấy được vào biến ở bước 1
        #endregion

        private void dtgView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //lấy dòng
            int row = e.RowIndex; //e : sự kiện chuột , e.RowIndex: chuột bấm vào dòng nào
            //loại bỏ dòng thừa
            if (row < 0 || row >= c.GetData().Count)
            {
                return;
            }
            //Lấy cột chứa ID và trích xuất
            _idWhenClick = int.Parse(dtgView.Rows[row].Cells[0].Value.ToString());
            FillDataToTextBox(); //điền các trường thông tin của đối tượng vào textbox
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //lấy ra được đối tượng có ID trùng với _idwhenclick
            Sach s = c.GetData().Where(x => x.Id == _idWhenClick).FirstOrDefault();
            //Lưu Ý: tuyệt đối ko sửa ID, chỉ các thuộc tính ko phải Key trong DB
            //Gán các giá trị mới từ textbox vào đối tượng tìm được
            s.Ten = txtTen.Text;
            s.Tacgia = txtTacgia.Text;
            s.Giatien = int.Parse(txtGiatien.Text);
            s.Nxb = cbxNhaxuatban.Text;
            //Gọi controller xử lý và hiển thị kết quả
            MessageBox.Show(c.SuaSach(s));
            //Load lại dữ liệu
            LoadViewData();
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            var ds = c.LoadViewDataSearch(txtTimkiem.Text);
            //Tạo cột
            //1. điền số lượng cột
            dtgView.ColumnCount = 5; //tương đương với thuộc tính đối tượng
            //2. đặt tên cột
            dtgView.Columns[0].Name = "Mã Sách";
            dtgView.Columns[1].Name = "Tên Sách";
            dtgView.Columns[2].Name = "Tác Giả";
            dtgView.Columns[3].Name = "Nhà Xuất Bản";
            dtgView.Columns[4].Name = "Giá Tiền";
            //3. Xử lý dòng
            //Quan trọng : Clear tất cả mỗi dòng khi load lại
            dtgView.Rows.Clear();
            //4.Thêm dữ liệu vào mỗi dòng tiếp theo
            foreach (var s in ds)
            {
                dtgView.Rows.Add(s.Id, s.Ten, s.Tacgia, s.Nxb, s.Giatien);
            }
        }
    }
}