using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battingStatis
{
    class Program
    {// This method calculates the batting average and slugging percentage 
      //for one or more baseball/Softball playes

        static void Main(string[] args)

        {
            CalcSumPercAver();//call to the method to calculate the batting sum, average and 
                                //Persentage for one or more baseball/softball

        }
        //The method calculates the batting sum, average and Persentage for one or more baseball/softball
        private static void CalcSumPercAver()
        {
            //
            Boolean batOn = true;
            while (batOn)
            {
                Console.WriteLine("Welcome to Batting Average Calculator!");

                Console.WriteLine("Enter number of times at bats");// reads number of bats input from Array
                int bats = int.Parse(Console.ReadLine());

                int[] array1 = new int[bats];//creates an array objects of bats
                readValue(array1);//call to readValue method to read user's input from array
                int count = array1.Length;//innitialising the number of count in the array
                int sum = 0;

                int result = 0;

                for (int i = 0; i < array1.Length; i++)
                {

                    sum += array1[i];//Calculates the sum of array


                    if (array1[i] != 0)
                    {
                        result++;//calculates the result of the count

                    }



                }
                Console.WriteLine("The sum of the array value = " + sum);
                Console.WriteLine("The result = " + result);
                double aver = ((double)result / count);
                Console.WriteLine("The average = " + aver);
                double batPercent = ((double)sum / count);
                Console.WriteLine("The bat percent = " + batPercent);

                Console.WriteLine("Do you want to enter another batter?");//validates if the user wants to continue to enter batter
                string response = Console.ReadLine();
                if (response == "Y" || response == "y")
                {
                    batOn = true;

                }

                else
                {
                    batOn = false;
                    break;

                }

            }
        }


        private static void readValue(int[] array1)
        {
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine("Please Enter the bat value ");//gets user's input
                int batValue = int.Parse(Console.ReadLine());
                array1[i] = batValue;//storing the user bat value into the array
                Console.WriteLine("The Array Value = " + batValue);
            }
        }


    }
    
}


