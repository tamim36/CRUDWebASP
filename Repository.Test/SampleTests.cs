using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Repository.Test
{
    public class SampleTests
    {

        Sample sample = new Sample();
        [Fact]
        public void Add_SampleValuesShouldCalculate()
        {
            // Arrange
            int expected = 5;

            // Act
            int actual = sample.Add(3, 2);
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
