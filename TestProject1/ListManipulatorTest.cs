using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Course_Exercises_Cs.UTs;

namespace TestProject1
{

    public class ListManipulatorTest
    {
        [Fact]
        public void FindMax_ShouldWork()
        {
            //Arange
            var list = new List<int>() { 1, 2, 3, 4, 5 };

            //Act
            var actual = ListManipulator.FindMax(list);

            //Assert
            Assert.Equal(5, actual);
        }

        [Fact]
        public void RemoveDuplicates_ShouldWork()
        {


            //Arange
            var list = new List<int> { 1, 2, 1, 2, 3, 4, 6 };
            //Act
            var actual = ListManipulator.RemoveDuplicates(list);
            //Assert
            Assert.Equal(new List<int> { 1, 2, 3, 4, 6 }, actual);
        }
    }
}
