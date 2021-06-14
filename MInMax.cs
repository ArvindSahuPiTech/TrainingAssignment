using System;

using System.Collections;
using System.Collections.Generic;
namespace MinMaxApp
{
    class Program
    {
        static int[] MinMaxCalc1(List<int> num)
        {
            int[] res = new int[2];
            res[0] = num[0];
            res[1] = num[1];
            for(int i=1; i<num.Count; i++)
            {
                if (res[0] > num[i])
                    res[0] = num[i];
                if ( res[1]<num[i])
                    res[1] = num[i];


            }
            return res;

        }

        static List<int> MinMaxCalc2(List<int> num)
        {
            List<int> res = new List<int>();
            res[0] = num[0];
            res[1] = num[1];
            for (int i = 1; i < num.Count; i++)
            {
                if (res[0] > num[i])
                    res[0] = num[i];
                if (res[1] < num[i])
                    res[1] = num[i];


            }
            return res;
        }



        //static ArrayList MinMaxCalc3(List<int> n)
        //{
        //    ArrayList res = new ArrayList();
        //    res[0] = n[0];
        //    res[1] = n[1];
        //    for (int i = 1; i < n.Count; i++)
        //    {
        //        if (res[0] > n[i])
        //            res[0] = n[i];
        //        if (res[1] < n[i])
        //            res[1] = n[i];


        //    }
        //    return res;
        //}

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<int> numbers = new List<int>() { 1, 3, 2, 4, 5, 7, 6, 9, 8 };
            Console.WriteLine("Numbers are :");
            for (int i = 0; i < numbers.Count; i++)
                Console.WriteLine(numbers[i]);
            //using array return type
            Console.WriteLine("Using array return type");
            int[] num = MinMaxCalc1(numbers);
            Console.WriteLine("Minimum : " + num[0] + " Maximum : " + num[1]);

            //using list return type
            Console.WriteLine("Using List return type");
            List<int> res  = MinMaxCalc2(numbers);
            Console.WriteLine("Minimum : " + res[0] + " Maximum : " + res[1]);

            //using arrayList return type
            Console.WriteLine("Using ArrayList return type");
            ArrayList res2 = MinMaxCalc3(numbers);
            Console.WriteLine("Minimum : " + res2[0] + " Maximum : " + res2[1]);


            Console.ReadLine();
        }
    }
}
