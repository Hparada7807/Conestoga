/* TriangleSolver.Test.cs 
 * Will test different values for the TriangleSolver Class
 * 
 * Revision History
 *      Hector Parada, 2020.02.21: Created
 *      
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROG2070HPAssign2;

using NUnit.Framework;

namespace PROG2070HPAssign2.Test
{
    [TestFixture]
    public class TriangleSolverTest
    {
        [Test]
        //picked values 1, 2, and 3 for the dimensions to show that the triangle will not form 
        public void Analyze_1_2_3_Result_NoTriangle()
        {
            //Arrange
            string result;

            //Act
            result = TriangleSolver.Analyze(1, 2, 3);

            //Assert
            Assert.AreEqual("Dose not form a trianlge", result);
        }

        [Test]
        //picked the values 1, 1, and 1 to show that the triangle will be an equalateral since all the sides are the same
        public void Analyze_1_1_1_Result_Eqalateral()
        {
            //Arrange
            string result;

            //Act
            result = TriangleSolver.Analyze(1, 1, 1);

            //Assert
            Assert.AreEqual("Triangle is a Equalateral", result);
        }

        [Test]
        //picked the values 5, 5, and 9 to show that the triangle will be an isosceles since two of the sides are the same
        //and that it will still make a triangle 
        public void Analyze_5_5_9_Result_Isosceles()
        {
            //Arrange
            string result;

            //Act
            result = TriangleSolver.Analyze(5, 5, 9);

            //Assert
            Assert.AreEqual("Triangle is a Isosceles Triangle", result);
        }

        [Test]
        //picked the values 4, 7, and 9 to show that the triangle will be an scalene since all of the sides are different
        //but it will still make a triangle 
        public void Analyze_4_7_9_Result_Scalene()
        {
            //Arrange
            string result;

            //Act
            result = TriangleSolver.Analyze(4, 7, 9);
            

            //Assert
            Assert.AreEqual("Triangle is a Scalene Triangle", result);
        }

        [Test]
        //picked the values 0, 5, and 9 to show that the triangle will not be form and that it also accepts 0 values
        public void Analyze_Zero_Dimension_One_Side_Result_No_From_Triangle()
        {
            //Arrange
            string result;

            //Act
            result = TriangleSolver.Analyze(0, 5, 9);

            //Assert
            Assert.AreEqual("Dose not form a trianlge", result);
        }
        [Test]
        //picked the values 0, 0, and 0 to show that the triangle will not be form when the user enters all zeros in the dimensions
        public void Analyze_Zero_Dimension_All_Sides_Result_No_From_Triangle()
        {
            //Arrange
            string result;

            //Act
            result = TriangleSolver.Analyze(0, 0, 0);

            //Assert
            Assert.AreEqual("Dose not form a trianlge", result);
        }
    }
}
