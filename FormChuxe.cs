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
        string chuoiketnoi = @"Data Source=DUNK\SQLEXPRESS;Initial Catalog=Quanlythuexe;Integrated Security=True";
        
        public FormChuxe()
        {
            InitializeComponent();
        }
        //load data
        void Loaddata()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable datatb = new DataTable();
            SqlConnection connection = new SqlConnection(chuoiketnoi);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Quanlychuxe";
            adapter.SelectCommand = command;
            datatb.Clear();
            adapter.Fill(datatb);
            GridChuxe.DataSource = datatb;
            fillcB();
        }

        private void Chuxe_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(chuoiketnoi);
            connection.Open();
            Loaddata();
            GridChuxe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        //button
        private void BT_them_Click(object sender, EventArgs e)
        {
            Chuxe cx = new Chuxe(cB_idcar.Text, tB_biensoxe.Text, tB_idchuxe.Text, tB_tenchuxe.Text, tB_sodienthoai.Text);
            cx.ThemCX();
            fillcB();
            Loaddata();
        }
        private void BT_sua_Click(object sender, EventArgs e)
        {
            Chuxe cx = new Chuxe(cB_idcar.Text, tB_biensoxe.Text, tB_idchuxe.Text, tB_tenchuxe.Text, tB_sodienthoai.Text);
            cx.SuaCX();
            Loaddata();
        }
        private void BT_xoa_Click(object sender, EventArgs e)
        {
            Chuxe cx = new Chuxe(cB_idcar.Text, tB_biensoxe.Text, tB_idchuxe.Text, tB_tenchuxe.Text, tB_sodienthoai.Text);
            cx.XoaCX();
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
        private void bt_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //fill data
        public void fillcB()
        {
            SqlConnection connection = new SqlConnection(chuoiketnoi);
            connection.Open();

            string query1 = "select IDcar from Quanlyxe" ;          
            SqlCommand cmd  = new SqlCommand(query1, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable datatb = new DataTable();
            datatb.Columns.Add("IDcar",typeof(string));
            datatb.Load(reader);
            cB_idcar.ValueMember = "IDcar";
            cB_idcar.DataSource = datatb;       
            
            connection.Close();
        }
        public void filltB()
        {
            SqlConnection connection = new SqlConnection(chuoiketnoi);
            connection.Open();

            string query = "select * from Quanlyxe where IDcar = '"+cB_idcar.Text+"' ";
            SqlCommand cmd = new SqlCommand(query,connection);
            DataTable datatt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(datatt);
            foreach(DataRow dataRow in datatt.Rows)
            {
                tB_biensoxe.Text = dataRow["Biensoxe"].ToString();
            }

            connection.Close();
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
        private void cB_idcar_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filltB();
        }
    }
}
