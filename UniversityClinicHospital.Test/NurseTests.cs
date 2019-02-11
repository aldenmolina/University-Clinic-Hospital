using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UniversityClinicHospital.Test
{
    public class NurseTests
    {
        [Fact]
        public void CreateNurse()
        {
            Nurse nurse = new Nurse();

        }

        [Fact]
        public void Has_Name()
        {
            Nurse nurse = new Nurse();

            Assert.Equal("George Michael", nurse.Name);
        }

        [Fact]
        public void Has_Employee_Number()
        {
            Nurse nurse = new Nurse();

            Assert.Equal(220022, nurse.EmployeeNumber);
        }

        [Fact]
        public void Has_Position()
        {
            Nurse nurse = new Nurse();

            Assert.Equal("Nurse", nurse.Position);
        }

        [Fact]
        public void Has_Salary()
        {
            Nurse nurse = new Nurse();

            nurse.PayEmployee();

            Assert.Equal(50000, nurse.Salary);
        }

        [Fact]
        public void Draw_Blood()
        {
            Nurse nurse = new Nurse();
            Patient pat = new Patient();

            nurse.DrawBlood(pat);

            Assert.Equal(10, pat.BloodLevel);
        }

        [Fact]
        public void Care_Patient()
        {
            Nurse nurse = new Nurse();
            Patient pat = new Patient();

            nurse.Care(pat);

            Assert.Equal(20, pat.HealthLevel);
        }

        [Fact]
        public void Has_Patients()
        {
            Nurse nurse = new Nurse();

            Assert.InRange(nurse.NumberOfPatients, 5, 20);
        }
    }
}
