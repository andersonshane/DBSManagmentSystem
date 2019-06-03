using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ShowStudents : DAO
    {
        DataTable dt = new DataTable();
        public DataTable Read()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Student", OpenCon());
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            return dt;
        }
    }
}
