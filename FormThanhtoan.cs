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
    public partial class FormThanhtoan : Form
    {      
        string chuoiketnoi = @"Data Source=DUNK\SQLEXPRESS;Initial Catalog=Quanlythuexe;Integrated Security=True";
             
        public FormThanhtoan()
        {
            InitializeComponent();           
        }

        // load data to grid
        private void Thanhtoan_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(chuoiketnoi);
            connection.Open();

            LoaddataGrid1();
            LoaddataGrid2();
            fillcB_idcar();
            fillcB_idkhachhang();
            fillcB_uudai();
            ResetData();
            Grid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        void LoaddataGrid1()
        {
            SqlConnection connectionGrid1 = new SqlConnection(chuoiketnoi);
            SqlCommand commandGrid1 = connectionGrid1.CreateCommand();

            commandGrid1.CommandText = "SELECT * FROM Quanlythanhtoan";
            DataTable datatbGrid1 = new DataTable();
            SqlDataAdapter adapterGrid1 = new SqlDataAdapter();
            adapterGrid1.SelectCommand = commandGrid1;
            datatbGrid1.Clear();
            adapterGrid1.Fill(datatbGrid1);
            Grid1.DataSource = datatbGrid1;

        }
        void LoaddataGrid2()
        {
            SqlConnection connectionGrid2 = new SqlConnection(chuoiketnoi);
            SqlCommand commandGrid2 = connectionGrid2.CreateCommand();

            commandGrid2.CommandText = "SELECT * FROM Quanlythanhtoan";
            DataTable datatbGrid2 = new DataTable();
            SqlDataAdapter adapterGrid2 = new SqlDataAdapter();
            adapterGrid2.SelectCommand = commandGrid2;
            datatbGrid2.Clear();
            adapterGrid2.Fill(datatbGrid2);
            Grid2.DataSource = datatbGrid2;
        }
        void LoaddataGrid2withCondition()
        {
            SqlConnection connectionGrid2 = new SqlConnection(chuoiketnoi);
            SqlCommand commandGrid2 = connectionGrid2.CreateCommand();
            
            commandGrid2.CommandText = "SELECT * FROM Quanlythanhtoan where ((IDcar = '"+cB_idxe.Text+"') AND (IDcus = '"+cB_idnguoithue.Text+ "')) OR( (IDcus = '" + cB_idnguoithue.Text + "') OR (IDcar = '" + cB_idxe.Text + "'))" ;
            DataTable datatbGrid2 = new DataTable();
            SqlDataAdapter adapterGrid2 = new SqlDataAdapter();
            adapterGrid2.SelectCommand = commandGrid2;
            datatbGrid2.Clear();
            adapterGrid2.Fill(datatbGrid2);
            Grid2.DataSource = datatbGrid2;
        }

        // fill data    
        public void fillcB_idcar()
        {
            SqlConnection connection = new SqlConnection(chuoiketnoi);
            connection.Open();
            string query1 = "select IDcar from Quanlyxe";

            SqlCommand cmd = new SqlCommand(query1, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable datatb = new DataTable();
            datatb.Columns.Add("IDcar", typeof(string));
            datatb.Load(reader);
            cB_idxe.ValueMember = "IDcar";
            cB_idxe.DataSource = datatb;
            connection.Close();

        }
        public void fillcB_idkhachhang()
        {
            SqlConnection connection = new SqlConnection(chuoiketnoi);
            connection.Open();
            string query1 = "select IDcus from Quanlykhachhang";

            SqlCommand cmd = new SqlCommand(query1, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable datatb = new DataTable();
            datatb.Columns.Add("IDcus", typeof(string));
            datatb.Load(reader);
            cB_idnguoithue.ValueMember = "IDcus";
            cB_idnguoithue.DataSource = datatb;
            connection.Close();
        }
        public void fillcB_uudai()
        {
            SqlConnection connection = new SqlConnection(chuoiketnoi);
            connection.Open();
            string query1 = "select Uudai from Uudai";

            SqlCommand cmd = new SqlCommand(query1, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable datatb = new DataTable();
            datatb.Columns.Add("Uudai", typeof(string));
            datatb.Load(reader);
            cB_uudai.ValueMember = "Uudai";
            cB_uudai.DataSource = datatb;
            connection.Close();
        }
        public void filltB_Tenkhachhang()
        {
            SqlConnection connection = new SqlConnection(chuoiketnoi);
            connection.Open();
            string query = "select * from Quanlykhachhang where IDcus = '" + tB_idkhachhang.Text + "' ";
            SqlCommand cmd = new SqlCommand(query, connection);
            DataTable datatt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(datatt);
            foreach (DataRow dataRow in datatt.Rows)
            {
                tB_tenkhachhang.Text = dataRow["Tenkhachhang"].ToString();
            }
            connection.Close();
        }
        private void Grid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = Grid2.CurrentRow.Index;
            tB_idhopdong.Text = Grid2.Rows[i].Cells[0].Value.ToString();
            tB_idkhachhang.Text = Grid2.Rows[i].Cells[1].Value.ToString();
            tB_idxe.Text = Grid2.Rows[i].Cells[2].Value.ToString();
            filltB_Tenkhachhang();
            tB_ngaytraxe.Text = Grid2.Rows[i].Cells[3].Value.ToString();
            tB_uudai.Text = "0";
            tB_tongtien.Text = Grid2.Rows[i].Cells[6].Value.ToString();

        }
        private void ResetData()
        {
            cB_idxe.Text = null;
            cB_idnguoithue.Text = null;
            cB_uudai.Text = null;
        }
        private void ReloadData()
        {
            this.Hide();
            LoaddataGrid1();
            LoaddataGrid2();
            this.Show();
        }

        //button
        private void bt_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void BT_search_Click(object sender, EventArgs e)
        {
            LoaddataGrid2withCondition();
            ResetData();
        }            
        private void BT_add_Click(object sender, EventArgs e)
        {
            int i = Grid2.CurrentRow.Index;
            Uudai uudai = new Uudai(cB_uudai.Text, int.Parse(tB_uudai.Text));
            uudai.ThemUD();
            tB_uudai.Text = uudai.PhanTramGiam.ToString();
        
            long chiphi = long.Parse(Grid2.Rows[i].Cells[5].Value.ToString());
            tB_tongtien.Text = uudai.TinhtienUD(chiphi).ToString();
        }

        private void BT_thanhtoan_Click(object sender, EventArgs e)
        {
            Thanhtoan tt = new Thanhtoan(tB_idkhachhang.Text,long.Parse(tB_tongtien.Text),tB_idhopdong.Text);
            tt.XacNhanTT();
            ReloadData();
        }
 
    }
}
