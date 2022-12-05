﻿using System;
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
    public partial class FormHopdong : Form
    {
       
        string chuoiketnoi = @"Data Source=DUNK\SQLEXPRESS;Initial Catalog=Quanlythuexe;Integrated Security=True";
        

        // load data to grid
        public FormHopdong()
        {
            InitializeComponent();
        }
        public void Loaddata()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable datatb = new DataTable();
            SqlConnection connection= new  SqlConnection(chuoiketnoi);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Quanlyhopdong";
            adapter.SelectCommand = command;
            datatb.Clear();
            adapter.Fill(datatb);
            GridHopdong.DataSource = datatb;           
            fillcB_idkhachhang();
            fillcB_idcar();
        }
        private void Hopdong_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(chuoiketnoi);
            connection.Open();                   
            Loaddata();
            resetData();
            GridHopdong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        //fill data
        public void fillcB_idcar()
        {
            SqlConnection connection = new SqlConnection(chuoiketnoi);
            connection.Open();
            string query1 = "select IDcar from Quanlyxe where Tinhtrangthue = N'" + "Chưa cho thuê" + "'";

            SqlCommand cmd = new SqlCommand(query1, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable datatb = new DataTable();
            datatb.Columns.Add("IDcar", typeof(string));
            datatb.Load(reader);
            cB_idcar.ValueMember = "IDcar";
            cB_idcar.DataSource = datatb;           
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
        public void filltB_Biensoxe()
        {
            SqlConnection connection = new SqlConnection(chuoiketnoi);
            connection.Open();
            string query = "select * from Quanlychuxe where IDcar = '" + cB_idcar.Text + "' ";
            SqlCommand cmd = new SqlCommand(query, connection);
            DataTable datatt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(datatt);
            foreach (DataRow dataRow in datatt.Rows)
            {
                tB_biensoxe.Text = dataRow["Biensoxe"].ToString();
            }
            connection.Close();
        }
        public void filltB_IDchuxe()
        {
            SqlConnection connection = new SqlConnection(chuoiketnoi);
            connection.Open();
            string query = "select * from Quanlychuxe where IDcar = '" + cB_idcar.Text + "' ";
            SqlCommand cmd = new SqlCommand(query, connection);
            DataTable datatt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(datatt);
            foreach (DataRow dataRow in datatt.Rows)
            {
                tB_idchuxe.Text = dataRow["IDchuxe"].ToString();
            }


            connection.Close();
        }
        public void filltB_Giathue()
        {
            SqlConnection connection2 = new SqlConnection(chuoiketnoi);
            connection2.Open();
            string query = "select * from Quanlyxe where IDcar = '" + cB_idcar.Text + "' ";
            SqlCommand cmd = new SqlCommand(query, connection2);
            DataTable datatt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(datatt);
           
            foreach (DataRow dataRow in datatt.Rows)
            {
                             
                tB_phithue.Text = String.Format( "{0:0}", dataRow["Giathue"]);
            }
            connection2.Close();
        }
        private void resetData()
        {
            cB_idcar.Text = null;
            tB_biensoxe.Text = null;
            tB_idchuxe.Text = null;
            cB_idnguoithue.Text = null;
            dTP_ngaythue.Text = "01/01/2023";
            dTB_ngaytra.Text = "01/01/2023";
            tB_phithue.Text = null;
        }
        private void GridHopdong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = GridHopdong.CurrentRow.Index;
            cB_idcar.Text = GridHopdong.Rows[i].Cells[0].Value.ToString();
            tB_biensoxe.Text = GridHopdong.Rows[i].Cells[1].Value.ToString();
            tB_idchuxe.Text = GridHopdong.Rows[i].Cells[2].Value.ToString();
            cB_idnguoithue.Text = GridHopdong.Rows[i].Cells[3].Value.ToString();
            dTP_ngaythue.Text = GridHopdong.Rows[i].Cells[4].Value.ToString();
            dTB_ngaytra.Text = GridHopdong.Rows[i].Cells[5].Value.ToString();       
            tB_phithue.Text = String.Format("{0:0}", GridHopdong.Rows[i].Cells[6].Value);
        }
        private void cB_idcar_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filltB_Biensoxe();
            filltB_IDchuxe();
            filltB_Giathue();
        }
        private void ReloadData()
        {
            fillcB_idcar();
            fillcB_idkhachhang();
            Loaddata();
            resetData();
        }
     
        //button        
        private void BT_them_Click(object sender, EventArgs e)
        {
            Hopdong hd = new Hopdong(cB_idcar.Text, tB_biensoxe.Text, tB_idchuxe.Text, cB_idnguoithue.Text, dTP_ngaythue.Text, dTB_ngaytra.Text, long.Parse(tB_phithue.Text));
            hd.ThemHD();

            Xe xe = new Xe(cB_idcar.Text);
            xe.CapnhatTrangthaiXe(true);
            ReloadData();
        }

        private void BT_sua_Click(object sender, EventArgs e)
        {
            Hopdong hd = new Hopdong(cB_idcar.Text, tB_biensoxe.Text, tB_idchuxe.Text, cB_idnguoithue.Text, dTP_ngaythue.Text, dTB_ngaytra.Text, long.Parse(tB_phithue.Text));
            hd.SuaHD();
            ReloadData();
        }

        private void BT_xoa_Click(object sender, EventArgs e)
        {
            Hopdong hd = new Hopdong(cB_idcar.Text);
            hd.XoaHD();

            Xe xe = new Xe(cB_idcar.Text);
            xe.CapnhatTrangthaiXe(false);
            ReloadData();         
        }
        private void bt_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void BT_reset_Click(object sender, EventArgs e)
        {
            resetData();
        }       
        
        private void BT_traxe_Click(object sender, EventArgs e)
        {          
            FormChiphiphatsinh userform = new FormChiphiphatsinh(cB_idcar.Text.ToString(),cB_idnguoithue.Text.ToString(),tB_phithue.Text);           
            userform.ShowDialog();
            this.Hide();
            Loaddata();
            this.Show();                   
        }
    }
}
