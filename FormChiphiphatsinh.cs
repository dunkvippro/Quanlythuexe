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
    public partial class FormChiphiphatsinh : Form
    {
        // connection
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable datatb = new DataTable();
        string chuoiketnoi = @"Data Source=DUNK\SQLEXPRESS;Initial Catalog=Quanlythuexe;Integrated Security=True";
        //
        //
        long tongtien = 0;
        long [] sotienphaitra = new long[100];      
        int soluongpt = 0;
        //
        //
        string IDcus, IDcar, chiphi;

        //
        public FormChiphiphatsinh(string IDcar,string IDcus,string chiphi)
        {
            InitializeComponent();
            this.IDcus = IDcus;
            this.IDcar = IDcar;
            this.chiphi = chiphi;
        }

        private void Chiphiphatsinh_Load(object sender, EventArgs e)
        {
            fillcB_vande();
        }

        private void cB_vandephatsinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void fillcB_vande()
        {
            SqlConnection connection1 = new SqlConnection(chuoiketnoi);
            connection1.Open();
            string query1 = "select Vande from Vandephatsinh";

            SqlCommand cmd = new SqlCommand(query1, connection1);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable datatb = new DataTable();
            datatb.Columns.Add("Vande", typeof(string));
            datatb.Load(reader);
            cB_vandephatsinh.ValueMember = "Vande";
            cB_vandephatsinh.DataSource = datatb;


            connection1.Close();

        }
        public void filltB_chiphi()
        {
            SqlConnection connection2 = new SqlConnection(chuoiketnoi);
            connection2.Open();
            string query = "select * from Vandephatsinh where Vande = N'" + cB_vandephatsinh.Text + "' ";
            SqlCommand cmd = new SqlCommand(query, connection2);
            DataTable datatt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(datatt);
            foreach (DataRow dataRow in datatt.Rows)
            {
                //tB_chiphi.Text = dataRow["Chiphi"].ToString();
                tB_chiphi.Text = String.Format( "{000:0}", dataRow["Chiphi"]);
            }

            connection2.Close();
        }

        
        private void Xoaptmang(long[] arr,int n,int N)
        {
           
            for (int i = n ; i < N; i++)
            {
                if (N == 1)
                {
                    arr[n] = 0;
                    return;
                }
                arr[i] = arr[i+1];
            }
            

        }
        
        private void loaddatatB_cacvande()
        {

            //tB_cacvande.Text += cB_vandephatsinh.Text.ToString() +" - "+tB_chiphi.Text.ToString() +  "\r\n";
            lB_cacvande.Items.Add(cB_vandephatsinh.Text.ToString() + " - " + tB_chiphi.Text.ToString() + "\r\n");
            sotienphaitra[soluongpt] = long.Parse(tB_chiphi.Text);
            sotienphaitra[soluongpt+1] = 0;
            soluongpt++;
            
        }
        private void loaddatatB_tongtien()
        {
            tongtien+= long.Parse(tB_chiphi.Text);
            tB_tongtien.Text = tongtien.ToString();
           
        }
        private void deletedatatB_tongtien()
        {
            Console.Write(lB_cacvande.SelectedIndex);
            long tong = sotienphaitra[lB_cacvande.SelectedIndex];
            Xoaptmang(sotienphaitra, lB_cacvande.SelectedIndex, soluongpt);
            soluongpt--;

            tB_tongtien.Text = (tongtien- tong).ToString();
            tongtien = tongtien - tong;

        }
        private void deletedatatB_cacvande()
        {
            deletedatatB_tongtien();
            lB_cacvande.Items.Remove(lB_cacvande.SelectedItem);
            
        }

        private void cB_vandephatsinh_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filltB_chiphi();
        }

        private void BT_them_Click(object sender, EventArgs e)
        {
            loaddatatB_cacvande();
            loaddatatB_tongtien();
        }

        private void BT_xoa_Click(object sender, EventArgs e)
        {
            deletedatatB_cacvande();
            
        }
        public void Capnhatchuachothue()
        {
            SqlConnection connection4 = new SqlConnection(chuoiketnoi);
            connection4.Open();
            string query = "update Quanlyxe set Tinhtrangthue = N'" + "Chưa cho thuê" + "' where IDcar = '" + IDcar + "'";
            SqlCommand cmd = new SqlCommand(query, connection4);
            cmd.ExecuteNonQuery();
            connection4.Close();
        }
        private void Xoadatagrid()
        {
            SqlConnection connection5 = new SqlConnection(chuoiketnoi);
            connection5.Open();
            
            SqlCommand command2 = connection5.CreateCommand();


            command2.CommandText = "DELETE FROM Quanlyhopdong WHERE IDcar = N'" + this.IDcar + "' ";

            command2.ExecuteNonQuery();
            connection5.Close();
            
        }

        private void BT_hoantat_Click(object sender, EventArgs e)
        {
            SqlConnection connection= new SqlConnection(chuoiketnoi);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            DateTime noww = DateTime.Now;
            Random rnd = new Random();
            int randomnumber = rnd.Next(100, 1000);
            long sum = long.Parse(tB_tongtien.Text.ToString()) + long.Parse(chiphi);
            command.CommandText = "insert into Quanlythanhtoan values( '"+randomnumber+"' ,'" + IDcus + "','" + IDcar + "', '" + noww + "','" + long.Parse(tB_tongtien.Text.ToString()) + "','" + long.Parse(chiphi)+ "','" + sum + "')";
            
            command.ExecuteNonQuery();
            Capnhatchuachothue();
            Xoadatagrid();
            this.Hide();
            
            
        }

        

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void tB_chiphi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
