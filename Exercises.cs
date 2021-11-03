/*
 * Copyright 2021 The MITRE Corporation. All Rights Reserved.
 */

using System;
using System.Collections.Generic;

namespace CSharpExercises
{
    // Enter the info below, then implement each function so that it passes
    // the unit test. Submit this file when you have completed the assignment.
    //
    // Name:Alexzander Sansiveri
    // Date:
    // Class/Program:Quantum Software

    class Exercises
    {
        // Returns an empty array of length n.
        // Works for n >= 0.
        //DONE
        public int[] Exercise1(int n)
        {
            // TODO
            int[] array = new int[n];
            return array;
        }

        // Returns an array containing the first n natural numbers.
        // Hint: the natural numbers are all of the integers in sequence,
        // starting at 1.
        // Works for n >= 0.
        //DONE
        public int[] Exercise2(int n)
        {
            // TODO
            int[] array = new int[n];
            for (int i = 1; i <= n; i++)
            {
                array[i - 1] = i;
            }
            return array;
        }

        // Returns a 2D string array with n rows and m columns.
        // The value of each element is its "Battleship" coordinates.
        // E.g., the value of the element in the 4th row, 3rd column is "C4".
        // Works for n, m >= 0.
        public string[,] Exercise3(int n, int m)
        {
            // TODO
            string[] alph = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M" };
            string[,] array = new string[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    
                    string el = alph[j] + (i + 1).ToString();
                    array[i, j] = el;
                }
            }
            return array;
        }

        // Returns the arithmetic mean of array.
        // Returns 0 if array is empty.
        //DONE
        public double Exercise4(int[] array)
        {
            // TODO
            if (array.Length == 0){
                return 0;
            }
            int total = 0;
            for (int i = 0; i < array.Length; i++)
            {
                total += array[i];
            }
            return total/array.Length;
        }

        // Returns n factorial (n!).
        // Works for n >= 0.
        //DONE
        public int Exercise5(int n)
        {
            // TODO
            int total = 1;

            for (int i = 1; i <= n; i++)
            {
                total = total * i;
            }

            return total;
        }

        // Adds a and b, and stores the sum in b without modifying a.
        //DONE
        public void Exercise6(ref int a, ref int b)
        {
            // TODO
            int sum = a + b;
            b = sum;
        }

        // Returns array in reverse order without modifying the original.
        //DONE
        public int[] Exercise7(int[] array)
        {
            // TODO
            int[] output = new int[array.Length];
            int j = 0;

            for (int i = array.Length - 1; i >= 0; i--)
            {
                output[j] = array[i];
                j++;
            }
            return output;
        }

        // Removes every odd-indexed element from array.
        // E.g., [ 0, 1, 2, 3, 4 ] becomes [ 0, 2, 4 ].
        //DONE
        public int[] Exercise8(ref int[] array)
        {

            // TODO
            List<int> input = new List<int>();

            for (int i = 0; i < array.Length; i ++)
            {
                if (i % 2 == 0) {
                    input.Add(array[i]);
                }
            }
            int[] output = input.ToArray();
            array = output;
            return array;
        }
    }
}
