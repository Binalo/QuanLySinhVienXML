using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        XuLy pr = new XuLy(); //tao doi tuong moi 
        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDocFile_Click(object sender, EventArgs e)
        {
            pr.HienThi(gridviewSinhvien);
        }
        public void Xoatextbox() // xoa cac text box trong form
        {
            txtmasv.Clear();
            txtHoten.Clear();
            txtLop.Clear();
            txtDiachi.Clear();
        }

        

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            Sinhvien sv = new Sinhvien();
            // tao moi tu cac thong tin trong text box
            sv.manv = txtmasv.Text;
            sv.hoten = txtHoten.Text;
            sv.lop = txtLop.Text;
            sv.diachi = txtDiachi.Text;

            //goi phuong thuc Them tu class Xuly
            pr.ThemSinhVien(sv);

            //Them XOng thi hien thi
            pr.HienThi(gridviewSinhvien);

            //Goi them pthuc xoa textbox sau khi them sv
            Xoatextbox();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Sinhvien sv = new Sinhvien();
            sv.manv = txtmasv.Text;
            sv.hoten = txtHoten.Text;
            sv.lop = txtLop.Text;
            sv.diachi = txtDiachi.Text;

            pr.SuaSinhVien(sv);
            pr.HienThi(gridviewSinhvien);

        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = gridviewSinhvien.SelectedCells[0].RowIndex; // lay ra chi so hang dang dc chon
            DataGridViewRow row = gridviewSinhvien.Rows[i]; // Lay ra du lieu cua hang 

            //lan luot dua cac cot vao textbox
            txtmasv.Text = Convert.ToString(row.Cells["masv"].Value);
            txtHoten.Text = Convert.ToString(row.Cells["hoten"].Value);
            txtLop.Text = Convert.ToString(row.Cells["lop"].Value);
            txtDiachi.Text = Convert.ToString(row.Cells["diachi"].Value);



        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sinhvien s = new Sinhvien();
            s.manv = txtmasv.Text;

            pr.XoaSinhVien(s);
            pr.HienThi(gridviewSinhvien); // hien thi lai du lieu sau khi xoa
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Sinhvien s = new Sinhvien();
            s.manv = txtmasv.Text;
            pr.TimSinhVien(s, gridviewSinhvien);
        }
    }
}
