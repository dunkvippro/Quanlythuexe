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
    public partial class FormChuxe : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string chuoiketnoi = @"Data Source=DUNK\SQLEXPRESS;Initial Catalog=Quanlythuexe;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();

        DataTable datatb = new DataTable();
        public FormChuxe()
        {
            InitializeComponent();
        }
        void Loaddata()
        {

            command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Quanlychuxe";
            adapter.SelectCommand = command;
            datatb.Clear();
            adapter.Fill(datatb);
            GridChuxe.DataSource = datatb;
            fillcB();

        }

        private void Chuxe_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(chuoiketnoi);
            connection.Open();
            
            Loaddata();
            GridChuxe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void fillcB()
        {
            SqlConnection connection1 = new SqlConnection(chuoiketnoi);
            connection1.Open();
            string query1 = "select IDcar from Quanlyxe" ;
           
            SqlCommand cmd  = new SqlCommand(query1, connection1);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable datatb = new DataTable();
            datatb.Columns.Add("IDcar",typeof(string));
            datatb.Load(reader);
            cB_idcar.ValueMember = "IDcar";
            cB_idcar.DataSource = datatb;
           
            connection1.Close();

        }

        public void filltB()
        {
            SqlConnection connection2 = new SqlConnection(chuoiketnoi);
            connection2.Open();
            string query = "select * from Quanlyxe where IDcar = '"+cB_idcar.Text+"' ";
            SqlCommand cmd = new SqlCommand(query,connection2);
            DataTable datatt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(datatt);
            foreach(DataRow dataRow in datatt.Rows)
            {
                tB_biensoxe.Text = dataRow["Biensoxe"].ToString();
            }


            connection2.Close();
        }

        

        private void BT_them_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();


            command.CommandText = "insert into Quanlychuxe values('" + cB_idcar.Text + "',N'" + tB_biensoxe.Text + "',N'" + tB_idchuxe.Text + "', N'" + tB_tenchuxe.Text + "',N'"+ tB_sodienthoai.Text+"' )";

           
            fillcB();


            command.ExecuteNonQuery();
            Loaddata();
            
        }

        private void BT_sua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();


            command.CommandText = "UPDATE Quanlychuxe SET  Biensoxe= N'" + tB_biensoxe.Text + "' ,IDchuxe =  N'" + tB_idchuxe.Text + "', Tenchuxe = N'"+ tB_tenchuxe.Text + "',Sdt = N'" + tB_sodienthoai.Text + "' WHERE IDcar= N'" + cB_idcar.Text + "' ";
            command.ExecuteNonQuery();
            Loaddata();
        }

        private void BT_xoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();


            command.CommandText = "DELETE FROM Quanlychuxe WHERE IDchuxe = N'" + tB_idchuxe.Text + "' ";
            
            command.ExecuteNonQuery();
            Loaddata();
        }

        private void BT_reset_Click(object sender, EventArgs e)
        {
            cB_idcar.Text = null;
            tB_biensoxe.Text = null;
            tB_idchuxe.Text = null;
            tB_tenchuxe.Text = null;
            tB_sodienthoai.Text = null;
        }

        private void GridChuxe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = GridChuxe.CurrentRow.Index;
            cB_idcar.Text = GridChuxe.Rows[i].Cells[0].Value.ToString();
            tB_biensoxe.Text = GridChuxe.Rows[i].Cells[1].Value.ToString();
            tB_idchuxe.Text = GridChuxe.Rows[i].Cells[2].Value.ToString();
            tB_tenchuxe.Text = GridChuxe.Rows[i].Cells[3].Value.ToString();
            tB_sodienthoai.Text = GridChuxe.Rows[i].Cells[4].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cB_idcar_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filltB();
        }
    }
}
