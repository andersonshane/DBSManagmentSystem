using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class AddStudent : DAO
    {
        public void AddNewStudent() { }
        public void AddNewStudent(string fn, string ln, string em, string ph, string add1, string add2,
            string city, string county, string level, string course)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Student (StudentFirstName, StudentSurname,StudentEmail,StudentPhone, StudentAddress1,StudentAddress2, StudentCity, StudentCounty, StudentLevel, StudentCourse) VALUES (@fn,@ln,@em,@ph,@add1,@add2,@city,@county,@level,@course)", OpenCon());
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
