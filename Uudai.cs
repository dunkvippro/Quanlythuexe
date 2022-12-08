using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Quanlythuexe
{
    public class Uudai 
    {
        private string tenUudai;
        private int phanTramGiam;
        public DataProvider dataProvider = new DataProvider();       
        public Uudai()
        {
        }
        public Uudai(string tenuudai, int phantramgiam)
        {
            this.tenUudai = tenuudai;
            this.phanTramGiam = phantramgiam;
        }
        public int PhanTramGiam { get => phanTramGiam; set => phanTramGiam = value; }
        public void ThemUD()
        {                      
            string query = "select * from Uudai where Uudai = N'" + tenUudai + "' ";            
            DataTable datatt = dataProvider.ExecuteQuery_TBox(query);          
            foreach (DataRow dataRow in datatt.Rows)
            {
                this.phanTramGiam =(int)dataRow["Phantramgiam"];
            }           
        }
        public long TinhtienUD(long chiphithue)
        {
            long tongtien;
            tongtien =chiphithue- (chiphithue*phanTramGiam/100);
            return tongtien;
        }    
    }
}
