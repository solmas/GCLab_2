using System;

namespace Lab_2
{
    class GCRoomDetailGenerator
    {
        static void CloseProgram()
        {
            Console.WriteLine("Thanks for using the GC Room Detail Generator, have a great day!");
            Console.ReadKey();
        }

        static void EnterDimensions()
        {

            //Enter length
            Console.WriteLine("Please enter room length in feet.");
            double length = Convert.ToDouble(Console.ReadLine());

            //Enter width
            Console.WriteLine("Please enter room width in feet.");
            double width = Convert.ToDouble(Console.ReadLine());

            //Enter height
            Console.WriteLine("Please enter room height in feet.");
            double height = Convert.ToDouble(Console.ReadLine());

            double roomPerimeter = (width * 2) + (length * 2);

            double roomArea = width * length;

            double roomVolume = width * height * length;

            Console.WriteLine("The room perimeter is " + roomPerimeter);

            Console.WriteLine("The room area is " + roomArea);

            Console.WriteLine("The room volume is " + roomVolume);

        }


        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");

            EnterDimensions();

            Console.WriteLine("Would you like to enter the dimensions of another room? Y or N");
            string runAgain = Console.ReadLine();


            if (runAgain == "Y")
            {
                EnterDimensions();
            }
            else
            {
                CloseProgram();
            }
        }
    }
}

