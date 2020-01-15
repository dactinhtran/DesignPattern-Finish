using SV_16T1021182.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Configuration;


namespace SV_16T1021182
{
    public partial class FrmTest : Form
    {
        private string dsConfigFile = "File";
        private string dsConfigDb = "SQL";
        private List<TheLoai> listTheLoai;
        private List<SanPham> listSanPham;
        public FrmTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listTheLoai = new List<TheLoai>();
            Repo_Text data = new Repo_Text();
            var source = data.GetTheLoaiRepo(dsConfigFile);
            listTheLoai = source.GetTheLoaiList();
            string output = "";
            foreach (var item in listTheLoai)
            {
                output += ("MaTheLoai: " + item.MaTheLoai + ", TenTheLoai: " + item.TenTheLoai + "\n");
            }
            richTextBox1.Text = output;
            if (listTheLoai != null)
            {
                MessageBox.Show("Da get tu datasource thanh cong!", "Thong bao",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listTheLoai = new List<TheLoai>();
            Repo_DB data = new Repo_DB();
            var source = data.GetTheLoaiRepo(dsConfigDb);
            listTheLoai = source.GetTheLoaiCoSanPhamList();
            string output = "";
            foreach (var item in listTheLoai)
            {
                output += ("MaTheLoai: " + item.MaTheLoai + ", TenTheLoai: " + item.TenTheLoai + "\n");
            }
            richTextBox1.Text = output;
            if (listTheLoai != null)
            {
                MessageBox.Show("Da get tu datasource thanh cong!", "Thong bao",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listSanPham = new List<SanPham>();
            Repo_Text data = new Repo_Text();
            var source = data.GetSanPhamRepo(dsConfigFile);
            listSanPham = source.GetSanPhamList("TL1");
            string output = "";
            foreach (var item in listSanPham)
            {
                output += ("MaSP: " + item.MaSanPham + ", TenSP: " + item.TenSanPham +" Giá"+ item.GiaBan+ "\n");
            }
            richTextBox1.Text = output;
            if (listTheLoai != null)
            {
                MessageBox.Show("Da get tu datasource thanh cong!", "Thong bao",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listSanPham = new List<SanPham>();
            Repo_DB data = new Repo_DB();
            var source = data.GetSanPhamRepo(dsConfigDb);
            listSanPham = source.GetSanPhamList("TL1");
            string output = "";
            foreach (var item in listSanPham)
            {
                output += ("MaSP: " + item.MaSanPham + ", TenSP: " + item.TenSanPham +"Giá: "+ item.GiaBan+ "\n");
            }
            richTextBox1.Text = output;
            if (listTheLoai != null)
            {
                MessageBox.Show("Da get tu datasource thanh cong!", "Thong bao",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
