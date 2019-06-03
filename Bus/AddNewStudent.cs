using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Configuration;
using System.Text.RegularExpressions;

namespace Bus
{
    public class AddNewStudent : AddStudent
    {
        public int StudentID { get; set; }
        public string StudentFN { get; set; }
        public string StudentSN { get; set; }
        public string StudentEmail { get; set; }
        public string StudentPhone { get; set; }
        public string StudentAdd1 { get; set; }
        public string StudentAdd2 { get; set; }
        public string StudentCity { get; set; }
        public string StudentCounty { get; set; }
        public string StudentAcademicLevel { get; set; }
        public string StudentAcademicCourse { get; set; }

        public AddNewStudent() { }
        public AddNewStudent(string fn, string sn, string em, string ph, string add1,
        string add2, string city, string county, string level, string course)
        {
            StudentFN = fn;
            StudentSN = sn;
            StudentEmail = em;
            StudentPhone = ph;
            StudentAdd1 = add1;
            StudentAdd2 = add2;
            StudentCity = city;
            StudentCounty = county;
            StudentAcademicLevel = level;
            StudentAcademicCourse = course;
        }
        public void AddStuToDB()
        {
            AddNewStudent(StudentFN, StudentSN, StudentEmail, StudentPhone, StudentAdd1,
                StudentAdd2, StudentCity, StudentCounty, StudentAcademicLevel, StudentAcademicCourse);
        }

        public bool Validate()
        {
            bool valid = false;
            int firstNameLength = 0;
            int.TryParse(ConfigurationManager.AppSettings["FirstNameLength"], out firstNameLength);
            int SurnameLength = 0;
            int.TryParse(ConfigurationManager.AppSettings["SurnameLength"], out SurnameLength);
            int Email = 0;
            int.TryParse(ConfigurationManager.AppSettings["Email"], out Email);
            int Phone = 0;
            int.TryParse(ConfigurationManager.AppSettings["Phone"], out Phone);
            int Add1 = 0;
            int.TryParse(ConfigurationManager.AppSettings["Add1"], out Add1);
            int Add2 = 0;
            int.TryParse(ConfigurationManager.AppSettings["Add2"], out Add2);
            int City = 0;
            int.TryParse(ConfigurationManager.AppSettings["City"], out City);
            int County = 0;
            int.TryParse(ConfigurationManager.AppSettings["County"], out County);
            int Level = 0;
            int.TryParse(ConfigurationManager.AppSettings["Level"], out Level);
            int Course = 0;
            int.TryParse(ConfigurationManager.AppSettings["Course"], out Course);


            if (StudentFN.Length >= firstNameLength && StudentSN.Length >= SurnameLength
                && StudentEmail.Length >= Email && StudentPhone.Length >= Phone
                && StudentAdd1.Length >= Add1 && StudentAdd2.Length >= Add2
                && StudentCity.Length >= City && StudentCounty.Length >= County
                && StudentAcademicLevel.Length >= Level && StudentAcademicCourse.Length >= Course)
            {
                valid = true;
            }
            return valid;
        }


    }



}

