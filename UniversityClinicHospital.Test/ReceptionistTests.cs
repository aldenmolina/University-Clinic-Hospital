using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UniversityClinicHospital.Test
{
    public class ReceptionistTests
    {
        [Fact]
        public void CreateReceptionist()
        {
            var rec = new Receptionist();

        }

        [Fact]
        public void Has_Name()
        {
            var rec = new Receptionist();

            Assert.Equal("Marylin Monroe", rec.Name);
        }

        [Fact]
        public void Has_Employee_Number()
        {
            var rec = new Receptionist();

            Assert.Equal(330033, rec.EmployeeNumber);
        }

        [Fact]
        public void Has_Position()
        {
            var rec = new Receptionist();

            Assert.Equal("Receptionist", rec.Position);
        }

        [Fact]
        public void Has_Salary()
        {
            var rec = new Receptionist();

            rec.PayEmployee();

            Assert.Equal(45000, rec.Salary);
        }

        [Fact]
        public void On_Phone()
        {
            var rec = new Receptionist();

            rec.Phone();


            Assert.True(rec.OnPhone);


        }
    }
}
