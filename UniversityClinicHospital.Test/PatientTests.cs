using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UniversityClinicHospital.Test
{
    public class PatientTests
    {
        [Fact]
        public void Create_Patient()
        {
            Patient pat = new Patient();
        }
        
        [Fact]
        public void Has_Name()
        {
            Patient pat = new Patient();

            Assert.Equal("Bojangles", pat.Name);
        }

        [Fact]
        public void Has_Blood_Level()
        {
            Patient pat = new Patient();

            Assert.Equal(20, pat.BloodLevel);
        }

        [Fact]
        public void Has_Health_Level()
        {
            Patient pat = new Patient();

            Assert.Equal(10, pat.HealthLevel);
        }

    }
}
