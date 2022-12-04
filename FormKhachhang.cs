using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Quanlythuexe
{
    public partial class FormKhachhang : Form
    {
        string chuoiketnoi = @"Data Source=DUNK\SQLEXPRESS;Initial Catalog=Quanlythuexe;Integrated Security=True";
       
        public FormKhachhang()
        {
            InitializeComponent();          
        }
        //load data to grid
        void Loaddata()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable datatb = new DataTable();
            SqlConnection connection= new SqlConnection(chuoiketnoi);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Quanlykhachhang";
            adapter.SelectCommand = command;
            datatb.Clear();
            adapter.Fill(datatb);
            GridKhachhang.DataSource = datatb;

        }
        private void User_Load(object sender, EventArgs e)
        {
            SqlConnection connection;
            connection = new SqlConnection(chuoiketnoi);
            connection.Open();
            Loaddata();
            GridKhachhang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        
        //button
        private void BT_them_Click(object sender, EventArgs e)
        {
            Khachhang kH = new Khachhang(tB_idkhachhang.Text, tB_name.Text, tB_diachi.Text, tB_sdt.Text);
            kH.ThemKH();
            Loaddata();
        }
        
        private void BT_sua_Click(object sender, EventArgs e)
        {
            Khachhang kH = new Khachhang(tB_idkhachhang.Text, tB_name.Text, tB_diachi.Text, tB_sdt.Text);
            kH.SuaThongTinKH();
            Loaddata();
        }
        
        private void BT_xoa_Click(object sender, EventArgs e)
        {
            Khachhang kH = new Khachhang(tB_idkhachhang.Text, tB_name.Text, tB_diachi.Text, tB_sdt.Text);
            kH.XoaKH();
            Loaddata();
        }

        private void BT_reset_Click(object sender, EventArgs e)
        {
            tB_idkhachhang.Text = null;
            tB_name.Text = null;
            tB_diachi.Text = null;
            tB_sdt.Text = null;
        }
        private void bt_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = GridKhachhang.CurrentRow.Index;
            tB_idkhachhang.Text = GridKhachhang.Rows[i].Cells[0].Value.ToString();
            tB_name.Text = GridKhachhang.Rows[i].Cells[1].Value.ToString();
            tB_diachi.Text = GridKhachhang.Rows[i].Cells[2].Value.ToString();
            tB_sdt.Text = GridKhachhang.Rows[i].Cells[3].Value.ToString();
        }
    }
}
