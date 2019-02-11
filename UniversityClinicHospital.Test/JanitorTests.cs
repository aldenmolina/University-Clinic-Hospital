using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UniversityClinicHospital.Test
{
    public class JanitorTests
    {
        [Fact]
        public void CreateJanitor()
        {
            var jan = new Janitor();
        }

        [Fact]
        public void Has_Name()
        {
            var jan = new Janitor();

            Assert.Equal("Tom Hanks", jan.Name);
        }

        [Fact]
        public void Has_Employee_Number()
        {
            var jan = new Janitor();

            Assert.Equal(440044, jan.EmployeeNumber);
        }

        [Fact]
        public void Has_Position()
        {
            var jan = new Janitor();

            Assert.Equal("Janitor", jan.Position);
        }

        [Fact]
        public void Has_Salary()
        {
            var jan = new Janitor();

            jan.PayEmployee();

            Assert.Equal(40000, jan.Salary);
        }

        [Fact]
        public void Is_Sweeping()
        {
            var jan = new Janitor();

            jan.Sweep();

            Assert.True(jan.Sweeping);
        }
    }
}
