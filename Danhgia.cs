using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlythuexe
{
    public class Danhgia
    {
        DataProvider dataProvider = new DataProvider();
        private string idCus;
        private string danhGia;
        private string idCar;
        public Danhgia()
        {
        }
        public Danhgia(string idcus,string danhgia,string idcar)
        {
            this.idCus = idcus;
            this.danhGia = danhgia;
            this.idCar = idcar;
        }
        public void ThemDG()
        {
           if (danhGia == "")
            {
                return;
            }
            string query = "insert into Quanlydanhgia values('"+idCus+"','"+idCar+"','"+danhGia+"')";
            dataProvider.ExecuteQuery(query);
        }
    }
}
