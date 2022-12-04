using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Quanlythuexe
{
    public class Chuxe
    {
        private string idCar;
        private string bienSoxe;
        private string idChuxe;
        private string tenChuxe;
        private string soDienthoai;

        string chuoiketnoi = @"Data Source=DUNK\SQLEXPRESS;Initial Catalog=Quanlythuexe;Integrated Security=True";
        public Chuxe()
        {
        }
        public Chuxe(string idcar,string biensoxe,string idchuxe,string tenchuxe,string sdt)
        {
            this.idCar = idcar;
            this.bienSoxe = biensoxe;
            this.idChuxe = idchuxe; 
            this.tenChuxe = tenchuxe;
            this.soDienthoai = sdt;

        }

        public void ThemCX()
        {
            SqlConnection connection = new SqlConnection(chuoiketnoi);
            connection.Open();
            SqlCommand command;
            command = connection.CreateCommand();

            command.CommandText = "insert into Quanlychuxe values('" + idCar + "',N'" + bienSoxe + "',N'" + idChuxe + "', N'" + tenChuxe + "',N'" + soDienthoai + "' )";

            command.ExecuteNonQuery();
            connection.Close();
        }
        public void XoaCX()
        {
            SqlConnection connection = new SqlConnection(chuoiketnoi);
            connection.Open();
            SqlCommand command;
            command = connection.CreateCommand();

            command.CommandText = "DELETE FROM Quanlychuxe WHERE IDchuxe = N'" + idChuxe + "' ";

            command.ExecuteNonQuery();
            connection.Close();
        }
        public void SuaCX()
        {
            SqlConnection connection = new SqlConnection(chuoiketnoi);
            connection.Open();
            SqlCommand command;
            command = connection.CreateCommand();

            command.CommandText = "UPDATE Quanlychuxe SET  Biensoxe= N'" + bienSoxe + "' ,IDchuxe =  N'" +idChuxe + "', Tenchuxe = N'" + tenChuxe + "',Sdt = N'" + soDienthoai + "' WHERE IDcar= N'" + idCar + "' ";

            command.ExecuteNonQuery();
            connection.Close();
        }


    }
}
