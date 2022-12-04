using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlythuexe
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
         
        }      

        private void Quanlichuxe_bt_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormChuxe userform = new FormChuxe();
            userform.ShowDialog();

            this.Show();
        }

        private void Quanlihopdong_bt_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormHopdong userform = new FormHopdong();
            userform.ShowDialog();

            this.Show();
        }

        private void Quanlixe_bt_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormXe userform = new FormXe();
            userform.ShowDialog();

            this.Show();
        }

        private void Quanliuser_bt_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormKhachhang userform = new FormKhachhang();
            userform.ShowDialog();
            
            this.Show(); 
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void Thanhtoan_bt_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormThanhtoan userform = new FormThanhtoan();
            userform.ShowDialog();

            this.Show();

        }

    }
    
}
