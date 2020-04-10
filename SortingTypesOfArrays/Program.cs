using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Straight_Selection_and_Insertion_Sort
{
    class Program
    {


        //-----------Main--:::Start::--------------------------------------------------------------------------------------------------------------------------------

        static void Main(string[] args)
        {
            Random Randomer = new Random();//----Generator of Random ints
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Randomer.Next(1, 100);
            }

            /* array = */

            int[] array2 = new int[10] { 3, 8, 9, 3, 56, 38, 32, 76, 28, 21 };
            int[] array3 = new int[8] { 1, 8, 6, 7, 2, 5, 9, 0 };

            //SelectionSort(array2);
            //InsertionSort(array2);
            BubbleSort(array2);
            //RecrusiveQuickSort(array3);
            //MergeSort(array2);
            Console.ReadLine();



        }

        //-----------Main--:::END::---------------------------------------------------------------------------------------------------------------------------------------





        //-----------Merege Sort--:::START::--------------------------------------------------------------------------------------------------------------------------------

        private static void MergeSort(int[] array)
        {


        }


        //-----------Merege Sort--:::END::--------------------------------------------------------------------------------------------------------------------------------








        //--Quick Sort----::START::---------------------------------------------------------------------------------------------------------------------------------


        private static void RecrusiveQuickSort(int[] array)
        {
            QuickSort(array, 0, array.Length - 1);
            for (int h = 0; h < array.Length; h++)
            {
                Console.WriteLine(array[h]);
            }
        }




        private static void QuickSort(int[] array, int left, int right)
        {
            int pointLeft = left;
            int pointRight = right;

            var pivot = array[(right + left) / 2];


            while (pointLeft <= pointRight)
            {

                while (array[pointLeft] < pivot)//----While Left pointer is smaller than pivot "Jump over to the next index" "++". Move left point 1 step to right
                {
                    pointLeft++;
                }


                while (array[pointRight] > pivot)//-----While Right Point is bigger than "pivot" move 1 step to left "Jump Over". 
                {
                    pointRight--;
                }


                if (pointLeft <= pointRight)
                {
                    (array[pointLeft], array[pointRight]) = (array[pointRight], array[pointLeft]);//-------Swap pointLeft withe PointRight
                    pointLeft++;
                    pointRight--;
                }



            }

            if (left < pointRight)
            {
                QuickSort(array, left, pointRight);
            }

            if (pointLeft < right)
            {
                QuickSort(array, pointLeft, right);
            }


        }


        //--Quick Sort----::End::------------------------------------------------------------------------------------------------------------------------------------------------------








        //--Bubble Sort----::Start::------------------------------------------------------------------------------------------------------------------------------------------------------


        static private void BubbleSort(int[] array)
        {

            bool swapped; //------Part of the BREAK 1
            for (int i = 0; i < array.Length - 1; i++)//----Loop Array
            {
                swapped = false;//------Part of the BREAK  2
                for (int a = 0; a < array.Length - 1; a++)//----While looping array loop all and swap so the samller value is before the big
                {
                    int current = a; //------Current value " The place of value we are looking at"
                    int next = a + 1; //----The place of the next value


                    if (array[current] > array[next])//---If current value is bigger than next value swap it

                        //it will swap all values till it gets to the end and than we have the next iteration of the array loop 
                        //" first for loop" . It will check for swapping till it gets the end of the array
                    {
                        (array[current], array[next]) = (array[next], array[current]);//---Swap
                        swapped = true; //Part of the BREAK 3
                    }

                }

                if (swapped == false) //BREAK      //In The for loop we are changing the places of the values if the next value is smaller than the current "Than swap it" this will continue till the end and than we begin from the beggining with the swapping till we have passed the whole lenght of the array. So neverminds what we we continue looking for the values even if there are no values for swapping because the algorithm says forloop the whole lengh and swap. But here we have bool that is checking if there was anything that was swapped. If nothing was swapped and we continue looking wi will just loose time. So here we have the breaker wich will break out because there are no more values to be swapped. 
                    // The first for loop is looping and the end is the length of the array. The second for loop is also looping and its end is the lenght of the array. Its for loop in For Loop. So if the first for loop is 1 the next wil loop the whole array and swapp if needed, than for loop 1 = 2 the second value now the second for loop will loop again the whole array and swapp if needed. Soif the second array dont swaps any values that means that all are in order. So the break will break out so the first for loop dont continues looping to the end of the array because the values are in order so we dont have to wait for it to loop and check.
                {
                    break;
                }


            }


            for (int h = 0; h <= array.Length - 1; h++)
            {
                Console.WriteLine(array[h]);

            }
        }

        //--Bubble Sort----::END::------------------------------------------------------------------------------------------------------------------------------------------------------






        //--Insertion Sort----::Start::------------------------------------------------------------------------------------------------------------------------------------------------------


        static private void InsertionSort(int[] array)
        {
            for (int a = 0; a < array.Length - 1; a++)//---Looping the array
            {
                int helper = a;

                while (helper != 0)//---Checking back
                {

                    if (array[helper] > array[helper + 1])//--if the current number is bigger and the next number is smaller than swap 
                    {

                        (array[helper + 1], array[helper]) = (array[helper], array[helper + 1]);///Swap

                    }

                    helper--;//---Minus so we can check all indexes back to 0
                }
            }

            for (int h = 0; h < array.Length; h++)//----Print
            {
                Console.WriteLine(array[h]);
            }


        }
        //--Insertion Sort----::End::------------------------------------------------------------------------------------------------------------------------------------------------------






        //--Selection Sort----::Start::------------------------------------------------------------------------------------------------------------------------------------------------------


        static private void SelectionSort(int[] array)//--------Sorting Method
        {

            for (int a = 0; a < array.Length - 1; a++)//---Hold Array Index for Swap
            {
                int min = a;
                for (int b = a + 1; b < array.Length; b++)//-----Find the samllest Value
                {

                    if (array[b] < array[min])
                    {
                        min = b;
                    }

                }

                int temp = array[a];//-----Swap
                array[a] = array[min];
                array[min] = temp;
            }


            for (int h = 0; h < array.Length; h++)
            {
                Console.WriteLine(array[h]);
            }

        }

        //--Selection Sort----::End::------------------------------------------------------------------------------------------------------------------------------------------------------

     


        //--Count Sort----::Start::------------------------------------------------------------------------------------------------------------------------------------------------------

                static private void CountSort()
                {

                }


        //--Count Sort----::END::------------------------------------------------------------------------------------------------------------------------------------------------------





        //--Shell Sort----::Start::------------------------------------------------------------------------------------------------------------------------------------------------------




        //--Shell Sort----::End::------------------------------------------------------------------------------------------------------------------------------------------------------







    }
}
