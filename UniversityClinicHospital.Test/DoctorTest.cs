using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UniversityClinicHospital.Test
{
    public class DoctorTest
    {
        [Fact]
        public void Create_Doctor()
        {
            Doctor doc = new Doctor();
        }

        [Fact]
        public void Doc_Has_Name()
        {
            Doctor doc = new Doctor();

            Assert.Equal("Billy Bob", doc.Name);
        }

        [Fact]
        public void Doc_Has_Employee_Number()
        {
            Doctor doc = new Doctor();

            Assert.Equal(110011, doc.EmployeeNumber);
        }

        [Fact]
        public void Doc_Has_Position()
        {
            Doctor doc = new Doctor();

            Assert.Equal("Doctor", doc.Position);
        }

        [Fact]
        public void Doc_Has_Specialty()
        {
            Doctor doc = new Doctor();

            Assert.Equal("Butt Doctor", doc.Specialty);
        }

        [Fact]
        public void Doc_Has_Salary()
        {
            Doctor doc = new Doctor();

            doc.PayEmployee();

            Assert.Equal(90000, doc.Salary);
        }

        [Fact]
        public void Draw_Blood()
        {
            Doctor doc = new Doctor();
            Patient pat = new Patient();

            doc.DrawBlood(pat);

            Assert.Equal(10, pat.BloodLevel);
        }

        [Fact]
        public void Treat_Patient()
        {
            Doctor doc = new Doctor();
            Patient pat = new Patient();

            doc.Treat(pat);

            Assert.Equal(30, pat.HealthLevel);
        }
    }

}
