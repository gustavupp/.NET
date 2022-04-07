using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class Arrays
    {
        static public void AboutArrays()
        {
            //Arrays
            //Rectangular Arrays
            var matrix = new int[3, 4] //[rows, columns]
            {
                {1,2,3,4},
                {5,6,7,8},
                {9,10,11,12},
            };

            //Jagged Arrays
            var jagged = new int[3][];
            jagged[0] = new int[4];
            jagged[1] = new int[4]; //define the columns separetly as the have different lengths
            jagged[2] = new int[4];

            //Console.WriteLine(matrix.Length);

            //Array.IndexOf()
            var newArr = new int[3] { 1, 2, 4 };
            var index = Array.IndexOf(newArr, 4);
            //Console.WriteLine(index);

            //Array.Clear()
            //Array.Clear(newArr, 0, 2); //replaces cleared items with 0 for int[]
            //foreach(var item in newArr)
            //{
                //Console.WriteLine(item);
            //} 

            //Array.Copy()
            int[] copyArray = new int[3];
            Array.Copy(newArr,copyArray,3);
            
            

            //Array.Reverse()
            Array.Reverse(copyArray);
            foreach (int n in copyArray)
            {
                Console.WriteLine(n);
            }

            //Array.Sort()
            Array.Sort(copyArray);
            foreach(var n in copyArray)
            {
                Console.WriteLine(n);
            }
        }
    
    }
}
