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
    public partial class FormXacNhanThanhToan : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string chuoiketnoi = @"Data Source=DUNK\SQLEXPRESS;Initial Catalog=Quanlythuexe;Integrated Security=True";
        string IDkhachhang, sotien, idhopdong;
        public FormXacNhanThanhToan(string IDkhachhang,string sotien,string idhopdong)
        {
            InitializeComponent();
            this.IDkhachhang = IDkhachhang;
            this.sotien = sotien;
            this.idhopdong = idhopdong;
        }


        private void FormXacNhanThanhToan_Load(object sender, EventArgs e)
        {
            tB_idkhachhang.Text = IDkhachhang;
            tB_sotien.Text = sotien;
        }

        private void BT_hoantat_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(chuoiketnoi);
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "DELETE FROM Quanlythanhtoan WHERE IDhopdong = N'" + idhopdong + "' ";
            command.ExecuteNonQuery();
            connection.Close();
            
            this.Hide();
        }      
    }
}
