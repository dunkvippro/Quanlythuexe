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
        public DataProvider dataProvider = new DataProvider();
        public FormThanhtoan()
        {
            InitializeComponent();           
        }
        // load data to grid
        private void Thanhtoan_Load(object sender, EventArgs e)
        {
            LoaddataGrid();
            LoaddataGridDanhgia();
            fillcB_idcar();
            fillcB_idkhachhang();
            fillcB_uudai();
            ResetData();
            Grid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        void LoaddataGrid()
        {
            string query = "SELECT * FROM Quanlythanhtoan";
            DataTable datatbGrid = dataProvider.ExecuteQuery_loaddata(query);           
            Grid1.DataSource = datatbGrid;           
        }   
        void LoaddataGridDanhgia()
        {
            string query = "SELECT * FROM Quanlydanhgia";
            DataTable datatbGrid = dataProvider.ExecuteQuery_loaddata(query);
            Grid2.DataSource = datatbGrid;
        }
        void LoaddataGrid2withCondition()
        {                    
            string query = "SELECT * FROM Quanlythanhtoan where ((IDcar = '"+cB_idxe.Text+"') AND (IDcus = '"+cB_idnguoithue.Text+ "')) OR( (IDcus = '" + cB_idnguoithue.Text + "') OR (IDcar = '" + cB_idxe.Text + "'))" ;
            DataTable datatbGrid2 = dataProvider.ExecuteQuery_loaddata(query);          
            Grid1.DataSource = datatbGrid2;
        }
        // fill data    
        public void fillcB_idcar()
        {           
            string query1 = "select IDcar from Quanlyxe";
            string query2 = "IDcar";           
            DataTable datatb = dataProvider.ExecuteQuery_CBox(query1,query2);           
            cB_idxe.ValueMember = "IDcar";
            cB_idxe.DataSource = datatb;         
        }
        public void fillcB_idkhachhang()
        {           
            string query1 = "select IDcus from Quanlykhachhang";
            string query2 = "IDcus";           
            DataTable datatb = dataProvider.ExecuteQuery_CBox(query1,query2);           
            cB_idnguoithue.ValueMember = "IDcus";
            cB_idnguoithue.DataSource = datatb;          
        }
        public void fillcB_uudai()
        {
            string query1 = "select Uudai from Uudai";
            string query2 = "Uudai";
            DataTable datatb = dataProvider.ExecuteQuery_CBox(query1, query2);         
            cB_uudai.ValueMember = "Uudai";
            cB_uudai.DataSource = datatb;          
        }
        public void filltB_Tenkhachhang()
        {         
            string query = "select * from Quanlykhachhang where IDcus = '" + tB_idkhachhang.Text + "' ";         
            DataTable datatt = dataProvider.ExecuteQuery_TBox(query);           
            foreach (DataRow dataRow in datatt.Rows)
            {
                tB_tenkhachhang.Text = dataRow["Tenkhachhang"].ToString();
            }            
        }
        private void Grid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = Grid1.CurrentRow.Index;
            tB_idhopdong.Text = Grid1.Rows[i].Cells[0].Value.ToString();
            tB_idkhachhang.Text = Grid1.Rows[i].Cells[1].Value.ToString();
            tB_idxe.Text = Grid1.Rows[i].Cells[2].Value.ToString();
            filltB_Tenkhachhang();
            tB_ngaytraxe.Text = Grid1.Rows[i].Cells[3].Value.ToString();
            tB_uudai.Text = "0";
            tB_tongtien.Text = Grid1.Rows[i].Cells[6].Value.ToString();
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
            LoaddataGridDanhgia();
            LoaddataGrid();
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
            int i = Grid1.CurrentRow.Index;
            Uudai uudai = new Uudai(cB_uudai.Text, int.Parse(tB_uudai.Text));
            uudai.ThemUD();
            tB_uudai.Text = uudai.PhanTramGiam.ToString();        
            long chiphi = long.Parse(Grid1.Rows[i].Cells[5].Value.ToString());
            tB_tongtien.Text = uudai.TinhtienUD(chiphi).ToString();
        }
        private void BT_thanhtoan_Click(object sender, EventArgs e)
        {
            Thanhtoan tt = new Thanhtoan(tB_idkhachhang.Text,long.Parse(tB_tongtien.Text),tB_idhopdong.Text,tB_idxe.Text);
            tt.XacNhanTT();
            ReloadData();
        }
        private void ResettB_uudai()
        {
            cB_uudai.Text = null;
            tB_sophantramgiam.Text = null;
        }
        private void BT_themmauudai_Click(object sender, EventArgs e)
        {
            string query = "insert into Uudai values(N'" + cB_uudai.Text + "',N'" + tB_sophantramgiam.Text + "' )";
            dataProvider.ExecuteQuery(query);
            ResettB_uudai();
            fillcB_uudai();
        }
    }
}
