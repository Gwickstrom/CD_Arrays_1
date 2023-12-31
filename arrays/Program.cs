﻿using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Declaring an array of length 5, initialized by default to all zeroes
            int[] numArray = new int[5];

            // Declaring an array with pre-populated values
            // For Arrays initialized this way, the length is determined by the size of the given data
            int[] numArray2 = {1,2,3,4,6};
            int[] array3;
            array3 = new int[] {1,3,5,7,9};
            Console.WriteLine(numArray2[4]);
            int[] arrayOfInts = {1, 2, 3, 4, 5};

            Console.WriteLine(arrayOfInts[0]);    // The first number lives at index 0.
            Console.WriteLine(arrayOfInts[1]);    // The second number lives at index 1.
            Console.WriteLine(arrayOfInts[2]);    // The third number lives at index 2.
            Console.WriteLine(arrayOfInts[3]);    // The fourth number lives at index 3.
            Console.WriteLine(arrayOfInts[4]);    // The fifth and final number lives at index 4.
            int[] arr = {1, 2, 3, 4};
            Console.WriteLine("The first number of the arr is " + arr[0]); 

            arr[0] = 8;
            Console.WriteLine("The first number of the arr is now " + arr[0]);
            
            string[] myCars = new string[4] { "Mazda Miata", "Ford Model T", "Dodge Challenger", "Nissan 300zx"}; 

            foreach (string car in myCars)
            {
                // We no longer need the index, because variable 'car' already contains each indexed value
                Console.WriteLine("I own a {0}", car);
            }
            // Multidimensional array declaration



            // This example contains 3 arrays -- each of these is length 2 -- all initialized to zeroes.
            int [,] array2D = new int[3,2];
            // This is equivalent to:
            //  int [,] array2D = new int[3,2]  {  { 0,0 }, { 0,0 }, { 0,0 } }; 

            // This example has 2 large rows that each contain 3 arrays -- and each of those arrays is length 4.
            int[,,] array3D = new int[2,3,4] 
                {
                    {  { 45,1,16,17 }, { 4,47,21,68 }, { 21,28,32,76 }  },
                    {  { 11,0,85,42 }, { 9,10,14,96 }, { 66,99,33,12 }  }
                };

            // Directly accessing a multidimensional array
            Console.WriteLine(array2D[0,1]);   // prints 0
            Console.WriteLine(array3D[1,0,3]); // prints 42



            // Jagged array declaration
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[4]; 
            jaggedArray[2] = new int[2];

            int[][] jaggedArray2 = new int[][] {
                new int[] {1,3,5,7,9},
                new int[] {0,2},
                new int[] {11,22,33,44}
            };

            // Short-hand form
            int[][] jaggedArray3 = {
                new int[] {1,3,5,7,9},
                new int[] {0,2},
                new int[] {11,22,33,44}
            };

            // You can even mix jagged and multi-dimensional arrays
            int[][,] jaggedArray4 = new int[3][,] 
            {
                new int[,] { {1,3}, {5,7} },
                new int[,] { {0,2}, {4,6}, {8,10} },
                new int[,] { {11,22}, {99,88}, {0,9} } 
            };

            // Working through each array in a jagged array
            foreach(int[] innerArr in jaggedArray){
                Console.WriteLine("Inner array length is {0}", innerArr.Length);
            }

            // Accessing a jagged array
            Console.WriteLine(jaggedArray2[0][1]); // 3
            Console.WriteLine(jaggedArray3[2][3]); // 44
        }
    }
}
