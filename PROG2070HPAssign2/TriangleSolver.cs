/* TriangleSolver.cs 
 * will determine all the side lengths and determine the triangle type
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

namespace PROG2070HPAssign2
{
    public static class TriangleSolver
    {
        /// <summary>
        /// will get 3 dimensions and determine if the trianlge is and equalateral, isoscels, scalene, or not a triangle 
        /// </summary>
        /// <param name="dimension1"></param>
        /// <param name="dimension2"></param>
        /// <param name="dimension3"></param>
        /// <returns></returns>
        public static string Analyze(int dimension1, int dimension2, int dimension3)
        {
            //string variables to determine what message is to be shown when trianlge is formed or not
            string answer = "";
            string eqalateral = "Triangle is a Equalateral";
            string scalene = "Triangle is a Scalene Triangle";
            string isosceles = "Triangle is a Isosceles Triangle";

            //if the sum of both sides are less or equal to the 3 side then the triangle will not form 
            if (dimension1 + dimension2 <= dimension3 ||
                    dimension2 + dimension3 <= dimension1 ||
                    dimension3 + dimension1 <= dimension2)
            {
                answer = "Dose not form a trianlge";
            }
            //if all sides are equal then the triangle is an equalteral
            else if (dimension1 == dimension2 && dimension1 == dimension3)
            {

                answer = eqalateral;
            }
            //if all sides are different but can also form a triangle then its a scalene triangle
            else if (dimension1 != dimension2 && dimension1 != dimension3 &&
                        dimension2 != dimension1 && dimension2 != dimension3 &&
                        dimension3 != dimension1 && dimension3 != dimension2)
            {
                answer = scalene;
            }

            //if two sides on the triangle are the same then its an isosceles
            else if (dimension1 == dimension2 || dimension1 == dimension3 ||
                    dimension2 == dimension1 || dimension2 == dimension3 ||
                    dimension3 == dimension1 || dimension3 == dimension2)
            {
                answer = isosceles;
            }


            return answer;
        }
    }
}

