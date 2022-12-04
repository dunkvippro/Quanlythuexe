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
        SqlConnection connection;
        SqlCommand command;
        string chuoiketnoi = @"Data Source=DUNK\SQLEXPRESS;Initial Catalog=Quanlythuexe;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();

        DataTable datatb = new DataTable();
        public FormKhachhang()
        {
            InitializeComponent();
        }

        void Loaddata()
        {

            command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Quanlykhachhang";
            adapter.SelectCommand = command;
            datatb.Clear();
            adapter.Fill(datatb);
            GridKhachhang.DataSource = datatb;

        }
        private void User_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(chuoiketnoi);
            connection.Open();
            Loaddata();
            GridKhachhang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void BT_them_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();


            command.CommandText = "insert into Quanlykhachhang values('" + tB_idkhachhang.Text + "',N'" + tB_name.Text + "',N'" + tB_diachi.Text + "', N'" + tB_sdt.Text +"' )";


            command.ExecuteNonQuery();
            Loaddata();

        }
        
        private void BT_sua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();


            command.CommandText = "UPDATE Quanlykhachhang SET Tenkhachhang= N'" + tB_name.Text + "' ,Diachi= N'" + tB_diachi.Text + "' ,Sdt =  N'" + tB_sdt.Text +"' WHERE IDcus = N'"+ tB_idkhachhang.Text+"'";
            command.ExecuteNonQuery();
            Loaddata();
        }
        

        private void BT_xoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();


            command.CommandText = "DELETE FROM Quanlykhachhang WHERE IDcus = N'" + tB_idkhachhang.Text + "' ";
            command.ExecuteNonQuery();
            Loaddata();
        }

        private void BT_reset_Click(object sender, EventArgs e)
        {
            tB_idkhachhang.Text = "";
            tB_name.Text = "";
            tB_diachi.Text = "";
            tB_sdt.Text = "";
        }

        private void tB_idkhachhang_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
