using System;
using System.Collections.Generic;

namespace OOP_HW9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print(Fibonachi());
            // 1 ✔
            Print(ArithmeticSequence(5, 0, 2));


            //2 ✔
            //Print(TakeN<long>(Fibonachi(), 15));

            //3 ✔
            //foreach(var number in RandomSequence())
            //    Console.WriteLine(number);
            //Print(RandomSequence());

            //4 ✔
            //foreach (var number in ArithmeticEndless(0, 7))
            //    Console.WriteLine(number);
            //Print(ArithmeticEndless(0, 7));

            //5 ✔
            //foreach (var number in Fibonachi())
            //    Console.WriteLine(number);
            //Print(Fibonachi());

            //6 ✔
            //Print(Combine(new int[] { 3, 6, 9 }, new string[] { "a", "GG", "gfchgchgvc" }));

            //7 ✔
            //Print(EvenNumbers(new int[] { 3, 4, 6, 8, 9, 2, 0, 7, 555, 9, 4, 456 }));

            //8 ✔
            //Print(SquaresSequence(new int[] { 1, 5, 10, 15 }));

            //9 ✔
            //foreach (var number in InterchangeSequence(new int[] { 1, 5, 9}, new int[] { 2, 6, 10}))
            //    Console.WriteLine(number);

            //10 ✔
            //Print(GetPairs(new int[] { 1, 2, 3, 4, 5 }));
        }
        public static void Print<T>(IEnumerable<T> seq)
        {
            foreach(var item in seq)
            {
                Console.WriteLine(item);
            }
        }
        #region Задание 1
        static IEnumerable<int> ArithmeticSequence(int n, int a0, int d)
        {
            int[] sequence = new int[n];
            for (int i = 0; i < n; i++)
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
        static IEnumerable<T> TakeN<T>(IEnumerable<T> seq, int n)
        {
            int i = 0;
            foreach (var item in seq)
                if (i < n)
                {
                    i++;
                    yield return item;
                }
                else
                {
                    break;
                }
        }
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
        static IEnumerable<Tuple<T, T1>> Combine<T, T1>(T[] seq1, T1[] seq2)
        {
            for (int i = 0; i < seq1.Length; i++)
                yield return new Tuple<T, T1>(seq1[i], seq2[i]);
        }
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
            for (int i = 0; i < seq1.Length; i++)
            {
                yield return seq1[i];
                yield return seq2[i];
            }
        }
        #endregion

        #region Задание 10
        static IEnumerable<Tuple<T, T>> GetPairs<T>(T[] seq)
        {
            for (int i = 0; i < seq.Length - 1; i++)
                yield return new Tuple<T, T>(seq[i], seq[i + 1]);
        }
        #endregion
    }
}
