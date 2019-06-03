using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class EditStudent :DAO
    {
        public void EditStu() { }
        public void EditStu(int id, string fn, string ln, string em, string ph, string add1, string add2,
            string city, string county, string level, string course)
        {
            string query = "UPDATE Student SET StudentFirstName=@fn, StudentSurname=@ln,StudentEmail=@em, StudentPhone=@ph, StudentAddress1=@add1, StudentAddress2=@add2, StudentCity=@city, StudentCounty=@county, StudentLevel= @level, StudentCourse=@course WHERE StudentId=@sid";
            SqlCommand cmd = new SqlCommand(query, OpenCon());
            cmd.Parameters.AddWithValue("@sid", id);
            cmd.Parameters.AddWithValue("@fn", fn);
            cmd.Parameters.AddWithValue("@ln", ln);
            cmd.Parameters.AddWithValue("@em", em);
            cmd.Parameters.AddWithValue("@ph", ph);
            cmd.Parameters.AddWithValue("@add1", add1);
            cmd.Parameters.AddWithValue("@add2", add2);
            cmd.Parameters.AddWithValue("@city", city);
            cmd.Parameters.AddWithValue("@county", county);
            cmd.Parameters.AddWithValue("@level", level);
            cmd.Parameters.AddWithValue("@course", course);
            cmd.ExecuteNonQuery();
            ClosedCon();
        }
    }
}

    
