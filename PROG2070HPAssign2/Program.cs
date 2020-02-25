/* Program.cs 
 * Ask user for triangle information and evalutes the dimensions
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
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            int dimension1 = 0;
            int dimension2 = 0;
            int dimension3 = 0;

            //will keep displaying the menu while te input value is greater then 2 or equal to 0 or equal to 1 or less then 0
            do
            {
                input = DisplayMenu();

                //when the input is one will ask the dimensions from the dimension method
                //if input is 2 then will exit out program
                switch (input)
                {
                    case 1:
                        dimension1 = Dimension();
                        dimension2 = Dimension();
                        dimension3 = Dimension();

                        Console.WriteLine(TriangleSolver.Analyze(dimension1, dimension2, dimension3));
                        Console.ReadLine();
                        break;
                    case 2:
                        Environment.Exit(0);
                        break;


                }

                
            } while (input == 0 || input < 0 || input > 2 || input == 1);
        }

        /// <summary>
        /// will display the menu and see if the user enters a correct number 
        /// </summary>
        /// <returns></returns>
        static int DisplayMenu()
        {
            int index;
            int userInput = 0;

            string userAnwser;
            string[] menu =
            {
                "Enter Triangle Dimensions",
                "Exit"
            };

            try
            {
                for (int i = 0; i < menu.Length; i++)
                {
                    index = i + 1;
                    Console.WriteLine(index + " - " + menu[i]);
                }

                userAnwser = Console.ReadLine();
                userInput = int.Parse(userAnwser);

                if(userInput == 0 || userInput > 2)
                {
                    Console.WriteLine("Invalid Option Please Try Again");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Option Please Try Again");
            }

            return userInput;
        }

        /// <summary>
        /// asks the user to enter a dimension for the triangle and validates if its an actual number
        /// </summary>
        /// <returns></returns>
        static int Dimension()
        {
            int dimension = 0;
            int check = -1;
            string userDimension;

            while (check < 0 )
            {
                Console.WriteLine("Please Enter a Dimension for the triangel that" +
                                    "is grater than 0");

                try
                {
                    userDimension = Console.ReadLine();
                    dimension = int.Parse(userDimension);

                    if (dimension < 0)
                    {
                        Console.WriteLine("Triangle Dimension must be grater than 0");
                    }
                    else
                    {
                        check = 0;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("invalid dimension try again");
                }
            }

            return dimension;
        }

    }
}
