using System;
using System.Collections.Generic;

namespace OOP_HW9
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 ✔?
            //foreach(var number in ArithmeticSequence(5, 0, 2))
            //    Console.WriteLine(number);

            //2

            //3 ✔
            //foreach(var number in RandomSequence())
            //    Console.WriteLine(number);

            //4 ✔
            //foreach (var number in ArithmeticEndless(0, 7))
            //    Console.WriteLine(number);

            //5 ✔
            //foreach (var number in Fibonachi())
            //    Console.WriteLine(number);

            //6
            //foreach (var number in Fibonachi())
            //    Console.WriteLine(number);

            //7 ✔
            //foreach (var number in EvenNumbers(new int[] { 3, 4, 6, 8, 9, 2, 0, 7, 555, 9, 4, 456}))
            //    Console.WriteLine(number);

            //8 ✔
            //foreach (var number in SquaresSequence(new int[] { 1, 5, 10, 15}))
            //    Console.WriteLine(number);

            //9 ✔
            //foreach (var number in InterchangeSequence(new int[] { 1, 5, 9}, new int[] { 2, 6, 10}))
            //    Console.WriteLine(number);

            //10 
            //foreach (var number in )
            //    Console.WriteLine(number);
        }

        #region Задание 1
        static IEnumerable<int> ArithmeticSequence(int n, int a0, int d)
        {
            int[] sequence = new int[n];
            for(int i = 0; i < n; i++)
            {
                sequence[i] = a0 + i * d;
                yield return sequence[i];
            }
        }

        //static void Print(int[] sequence)
        //{
        //    for(int i = 0; i < sequence.Length; i++)
        //        yield 
        //}
        #endregion

        #region Задание 2

        #endregion

        #region Задание 3
        static IEnumerable<int> RandomSequence()
        {
            var random = new Random();

            while (true)
            {
                yield return random.Next();
            }
        }
        #endregion

        #region Задание 4
        static IEnumerable<int> ArithmeticEndless(int a0, int d)
        {
            while (true)
            {
                yield return a0;
                a0 += d;
            }
        }
        #endregion

        #region Задание 5
        static IEnumerable<long> Fibonachi()
        {
            long a = 0;
            long b = 1;
            long c;
            yield return 0;
            yield return 1;
            while (true)
            {
                c = a + b;
                yield return c;
                a = b;
                b = c;
            }
        }
        #endregion

        #region Задание 6
        //static Tuple<T, T1> Combine<T, T1>(List<T> seq1, List<T1> seq2)
        //{
            
        //}
        #endregion

        #region Задание 7
        static IEnumerable<int> EvenNumbers(int[] seq)
        {
            foreach (var number in seq)
                if (number % 2 == 0)
                    yield return number;
        }
        #endregion

        #region Задание 8
        static IEnumerable<int> SquaresSequence(int[] seq)
        {
            foreach (var number in seq)
                yield return number * number;
        }
        #endregion

        #region Задание 9
        static IEnumerable<int> InterchangeSequence(int[] seq1, int[] seq2)
        {
            for(int i = 0; i < seq1.Length; i++)
            {
                yield return seq1[i];
                yield return seq2[i];
            }
        }
        #endregion

        #region Задание 10
        //static IEnumerable<int> GetPairs(int[] seq1, int[] seq2)
        //{

        //}
        #endregion
    }
}
