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
        DataProvider dataprovider = new DataProvider();
        
        long tongtien = 0;
        long [] sotienphaitra = new long[100];      
        int soluongpt = 0;
              
        string IDcus, IDcar, chiphi;   
        public FormChiphiphatsinh(string IDcar,string IDcus,string chiphi)
        {
            InitializeComponent();
            this.IDcus = IDcus;
            this.IDcar = IDcar;
            this.chiphi = chiphi;
        }
        //load data
        private void Chiphiphatsinh_Load(object sender, EventArgs e)
        {
            fillcB_vande();
        }
        private void loaddatatB_cacvande()
        {
            lB_cacvande.Items.Add(cB_vandephatsinh.Text.ToString() + " - " + tB_chiphi.Text.ToString() + "\r\n");
            sotienphaitra[soluongpt] = long.Parse(tB_chiphi.Text);
            sotienphaitra[soluongpt + 1] = 0;
            soluongpt++;
        }
        private void loaddatatB_tongtien()
        {
            tongtien += long.Parse(tB_chiphi.Text);
            tB_tongtien.Text = tongtien.ToString();
        }
        //fill data
        public void fillcB_vande()
        {           
            string query1 = "select Vande from Vandephatsinh";
            string needAdd = "Vande";        
            DataTable datatb = dataprovider.ExecuteQuery_CBox(query1,needAdd);       
            cB_vandephatsinh.ValueMember = "Vande";
            cB_vandephatsinh.DataSource = datatb;
        }
        public void filltB_chiphi()
        {           
            string query = "select * from Vandephatsinh where Vande = N'" + cB_vandephatsinh.Text + "' ";
            DataTable datatt = dataprovider.ExecuteQuery_TBox(query);
            foreach (DataRow dataRow in datatt.Rows)
            {              
                tB_chiphi.Text = String.Format( "{000:0}", dataRow["Chiphi"]);
            }          
        }
        // update data      
        private void deletedatatB_tongtien()
        {            
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
        private void Xoadatagrid()
        {
            string query = "DELETE FROM Quanlyhopdong WHERE IDcar = N'" + this.IDcar + "' ";
            dataprovider.ExecuteQuery(query);
        }
        private void cB_vandephatsinh_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filltB_chiphi();
        }
        //button
        private void BT_them_Click(object sender, EventArgs e)
        {
            loaddatatB_cacvande();
            loaddatatB_tongtien();
        }
        private void BT_xoa_Click(object sender, EventArgs e)
        {
            deletedatatB_cacvande();           
        }             
        private void BT_hoantat_Click(object sender, EventArgs e)
        {
            DateTime noww = DateTime.Now;
            Random rnd = new Random();
            int randomnumber = rnd.Next(100, 1000);
            long sum = long.Parse(tB_tongtien.Text.ToString()) + long.Parse(chiphi);

            string query = "insert into Quanlythanhtoan values( '" + randomnumber + "' ,'" + IDcus + "','" + IDcar + "', '" + noww + "','" + long.Parse(tB_tongtien.Text.ToString()) + "','" + long.Parse(chiphi) + "','" + sum + "')";
            dataprovider.ExecuteQuery(query);           
            
            Xe xe =new Xe(IDcar);
            xe.CapnhatTrangthaiXe(false);

            Xoadatagrid();
            this.Hide();                        
        }
        private void Xoaptmang(long[] arr, int n, int N)
        {
            for (int i = n; i < N; i++)
            {
                if (N == 1)
                {
                    arr[n] = 0;
                    return;
                }
                arr[i] = arr[i + 1];
            }
        }
    }
}
