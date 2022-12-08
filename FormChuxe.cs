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
        public DataProvider dataProvider = new DataProvider();
        public FormChuxe()
        {
            InitializeComponent();
        }
        //load data
        void Loaddata()
        {
            string query = "SELECT * FROM Quanlychuxe";
            DataTable datatb =dataProvider.ExecuteQuery_loaddata(query) ;                     
            GridChuxe.DataSource = datatb;
            fillcB();
        }
        private void Chuxe_Load(object sender, EventArgs e)
        {         
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
            string query1 = "select IDcar from Quanlyxe" ;
            string query2 = "IDcar";
            DataTable datatb = dataProvider.ExecuteQuery_CBox(query1, query2);          
            cB_idcar.ValueMember = "IDcar";
            cB_idcar.DataSource = datatb;       
        }
        public void filltB()
        {
            string query = "select * from Quanlyxe where IDcar = '"+cB_idcar.Text+"' ";          
            DataTable datatt = dataProvider.ExecuteQuery_TBox(query);          
            foreach(DataRow dataRow in datatt.Rows)
            {
                tB_biensoxe.Text = dataRow["Biensoxe"].ToString();
            }         
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
