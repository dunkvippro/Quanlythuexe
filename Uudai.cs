using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Quanlythuexe
{
    public class Uudai : FormThanhtoan
    {
        private string tenUudai;
        private int phanTramGiam;

        string chuoiketnoi = @"Data Source=DUNK\SQLEXPRESS;Initial Catalog=Quanlythuexe;Integrated Security=True";

        public Uudai()
        {
        }
        public Uudai(string tenuudai, int phantramgiam)
        {
            this.tenUudai = tenuudai;
            this.phanTramGiam = phantramgiam;

        }

        public int PhanTramGiam { get => phanTramGiam; set => phanTramGiam = value; }

        public void ThemUD(){
            
            SqlConnection connection = new SqlConnection(chuoiketnoi);
            connection.Open();
            string query = "select * from Uudai where Uudai = N'" + tenUudai + "' ";
            SqlCommand cmd = new SqlCommand(query, connection);
            DataTable datatt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(datatt);
            foreach (DataRow dataRow in datatt.Rows)
            {
                this.phanTramGiam =(int)dataRow["Phantramgiam"];
            }
            connection.Close();
        }
        public long TinhtienUD(long chiphithue)
        {
            long tongtien;
            tongtien =chiphithue- (chiphithue*phanTramGiam/100);
            return tongtien;
        }


    }
}
