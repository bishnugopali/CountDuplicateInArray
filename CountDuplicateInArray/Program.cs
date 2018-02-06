using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDuplicateInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //a program in C# Sharp to count a total number of duplicate elements in an array. 
            int i, j;
            int n, mm=1,count=0;
            int[] arr1 = new int[100];
            int[] arr2 = new int[100];
            int[] arr3 = new int[100];
            Console.Write("Input the number of elements to be stored in the array :");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            /*----------------- copy in other array ------------------------------------*/
            for (i = 0; i < n; i++)
            {
                arr2[i] = arr1[i];
                arr3[i] = 0;
            }
            /*------------------- mark the elements are duplicate -------------------------*/
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        arr3[j] = mm;
                        mm++;
                    }
                }
                mm = 1;
            }

            for (i = 0; i < n; i++)
            {

                if (arr3[i] == 2)
                {
                    count++;
                }
            }
            Console.Write("The number of duplicate elements is: {0} \n", count);

            Console.Write("\n\n");
            Console.ReadLine();
        }
    }
}
