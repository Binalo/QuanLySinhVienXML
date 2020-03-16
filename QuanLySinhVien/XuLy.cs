using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
namespace QuanLySinhVien
{
    class XuLy
    {
        XmlDocument doc;
        XmlElement root;

        string filename;
        public XuLy()
        {
            doc = new XmlDocument();
            filename = "SinhVien.xml";
            doc.Load(filename);

            root = doc.DocumentElement; // lay phan tu goc trong tai lieu

        }

        public void HienThi(DataGridView grd) // Hien thi tai lieu trong 1 datagridview
        {
            grd.Rows.Clear();
            grd.ColumnCount = 4; // dat 4 cot vi du lieu co 4 cot
            XmlNodeList li = root.SelectNodes("sinhvien"); // lay du lieu da nhap o file xml

            int i = 0;
            foreach(XmlNode item in li) // vong lap de lay ra tung phan tu con trong ds
            {
                // them 1 hang  moi vao datagridview ,hang nay hien tai rong, chua co thong tin cac cot
                grd.Rows.Add();
                // them du lieu cho cot 1 la masv, lay ra thuoc tinh sv cua masv
                grd.Rows[i].Cells[0].Value = item.Attributes[0].InnerText;
                grd.Rows[i].Cells[1].Value = item.SelectSingleNode("hoten").InnerText;
                grd.Rows[i].Cells[2].Value = item.SelectSingleNode("lop").InnerText;
                grd.Rows[i].Cells[3].Value = item.SelectSingleNode("diachi").InnerText;
                i++;
            }
        }
        
        public void ThemSinhVien(Sinhvien s)
        {
            XmlElement sv = doc.CreateElement("sinhvien"); //tao phan tu sinh vien
            sv.SetAttribute("masv", s.manv); //them thuoc tinh masv cho sinhvien

            XmlElement hoten = doc.CreateElement("hoten");  //tao phan tu ho ten
            hoten.InnerText = s.hoten;  //tao Text cho phan tu ho ten

            XmlElement lop = doc.CreateElement("lop");  //tao phan tu lop
            lop.InnerText = s.lop;  //tao Text cho phan tu lop

            XmlElement diachi = doc.CreateElement("diachi");  //tao phan tu diachi
            diachi.InnerText = s.diachi;  //tao Text cho phan tu diachi

            //AppendChild de tao mqh cha con
            sv.AppendChild(hoten);
            sv.AppendChild(lop);
            sv.AppendChild(diachi);

            root.AppendChild(sv);
            doc.Save(filename);
        }
    }
}
