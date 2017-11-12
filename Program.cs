using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //The goal in this program is to sort an array from lowest to highest

            //This is our initial array
            int[] myArray = new int[] { 7, 22, 12, 35, 55, 18 };

            //This integer will be used to store our switched values in while rearranging the array
            int num;

            do
            {
                num = 0; //We reset the value of the switch integer
                for (int i = 0; i < (myArray.Length - 1); i++) //This for loop will run through each value of the array, except the last one because we are comparing values and the last value of the array has nothing after it to compare to.
                {
                    if (myArray[i] > myArray[i + 1]) //This is comparing 2 values from the array to find which is greater than the other, and storing the greater value in the switch integer to move in in the array.
                    {
                        num = myArray[i];
                        myArray[i] = myArray[i + 1];
                        myArray[i + 1] = num;
                    }
                }

            } while (num != 0); //This do while loop will run until the program is no longer making switches between the integers in the array

            foreach (var item in myArray) //This prints each integer of the array in a line
            {
                Console.Write(item + " ");
            }
            Console.ReadLine();


        }
    }
}
