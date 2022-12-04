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
    public partial class FormXe : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string chuoiketnoi = @"Data Source=DUNK\SQLEXPRESS;Initial Catalog=Quanlythuexe;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable datatb = new DataTable();

        void Loaddata()
        {          
            command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Quanlyxe";
            adapter.SelectCommand = command;
            datatb.Clear();
            adapter.Fill(datatb);
            GridXe.DataSource = datatb;
        }
 
        public FormXe()
        {
            InitializeComponent();
        }


        private void Xe_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(chuoiketnoi);
            connection.Open();
            Loaddata();
            GridXe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
       
        private void BT_them_Click(object sender, EventArgs e)
        {
            Xe xe1 = new Xe(tB_id.Text,tB_hangxe.Text,tB_biensoxe.Text,long.Parse(tB_giathue.Text),cB_tinhtrangxe.Text,cB_tinhtrangthue.Text);
            xe1.ThemXe();
            Loaddata();
           
        }

        private void BT_sua_Click(object sender, EventArgs e)
        {
            Xe xe2 = new Xe(tB_id.Text, tB_hangxe.Text, tB_biensoxe.Text, long.Parse(tB_giathue.Text), cB_tinhtrangxe.Text, cB_tinhtrangthue.Text);
            xe2.SuaThongTinXe();
            Loaddata();
        }

        private void BT_xoa_Click(object sender, EventArgs e)
        {
            Xe xe2 = new Xe();
            xe2.IdCar = tB_id.Text;
            xe2.XoaXe();          
            Loaddata();
        }

        private void BT_reset_Click(object sender, EventArgs e)
        {
            tB_id.Text = "";
            tB_hangxe.Text = "";
            tB_biensoxe.Text = "";
            tB_giathue.Text = "";
            cB_tinhtrangxe.Text = null;
            cB_tinhtrangthue.Text = null;
        }

        private void GridXe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;           
            i = GridXe.CurrentRow.Index;
            tB_id.Text = GridXe.Rows[i].Cells[0].Value.ToString();
            tB_hangxe.Text = GridXe.Rows[i].Cells[2].Value.ToString();
            tB_biensoxe.Text = GridXe.Rows[i].Cells[1].Value.ToString();          
            tB_giathue.Text = GridXe.Rows[i].Cells[3].Value.ToString();
            cB_tinhtrangxe.Text = GridXe.Rows[i].Cells[4].Value.ToString();
            cB_tinhtrangthue.Text = GridXe.Rows[i].Cells[5].Value.ToString();           
        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tB_Chuxe_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
