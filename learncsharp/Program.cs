using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text.Json.Nodes;

namespace learncsharp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //int a = 5;
            //a = 10;
            //double b = a;
            //Console.WriteLine(b);
            //double c = 10;
            //int d = (int) c;
            //Console.WriteLine(d);
            //Type type = d.GetType();
            //Console.WriteLine(type);
            string str2 = "jack sparrow";
            string res = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str2);
            Console.WriteLine(res);
            string str = "educative";

            //if (str.Length == 0)
            //	System.Console.WriteLine("Empty String");
            //else if (str.Length == 1)
            //	System.Console.WriteLine(char.ToUpper(str[0]));
            //else
            System.Console.WriteLine(char.ToUpper(str[0]) + str.Substring(1));
            int[] a = new int[10];
            int[] arrw = { 45, 60, 20, 15, 89, 72, 91, 8, 23, 10 };
            int e = arrw.Length / 2;
            //for (int i = 0; i <= arrw.Length; i++)
            //{
            //	if (i < e)
            //	{
            //		Console.WriteLine(arrw[i]);
            //	}

            //	else if (i >= e && i < arrw.Length)
            //	{
            //		Console.WriteLine(arrw[i]);
            //	}
            //}
            int[] arr = { 45, 60, 20, 15, 89, 72, 91, 8, 23, 10, 11, 45, 56, 85, 55 };
            int f = arr.Length / 3;
            List<int> k = new List<int>();
            List<int> l = new List<int>();
            List<int> m = new List<int>();
            for (int i = 0; i <= arr.Length; i++)
            {
                if (i < f)
                {
                    k.Add(arr[i]);
                }
                if (i >= f && i < f * 2)
                {
                    l.Add(arr[i]);
                }
                if (i >= f * 2 && i < f * 3)
                {
                    m.Add(arr[i]);
                }
            }

            //foreach (var item in k)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();
            //foreach (var item in l)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();
            //foreach (var item in m)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();

            int[] arr2 = { 30, 60, 20, 15, 89, 72, 95, 8, 23, 10 };
            int g = arr2.Length / 2;
            //int jj = arr2[arr2.Length - g];

            List<int> x = new List<int>();
            List<int> y = new List<int>();
            List<int> z = new List<int>();
            //int am = 0;
            for (int i = 0; i <= arr2.Length; i++)
            {
                if (i < g)
                {
                    x.Add(arr2[i]);
                }

                if (arr2.Length % 2 == 0)
                {
                    if (i >= g && i < arr2.Length)
                    {
                        z.Add(arr2[i]);
                    }
                }
                else
                {
                    if (i > g && i < arr2.Length)
                    {
                        z.Add(arr2[i]);
                    }
                }

                //if (i <= g && i >= g && i >= g && i < arr2.Length)
                //{
                //     //am = arr2[i];
                //    y.Add(arr2[i]);
                //}
                //if (i >= g && i < arr2.Length)
                //{
                //    z.Add(arr2[i]);
                //}
            }

            foreach (var item in x)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            //Console.WriteLine(am);
            foreach (var item in y)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            foreach (var item in z)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            //int[] firstArray = arr.Take(arr.Length  / 2).ToArray();
            //int[] secondArray = arr.Skip(arr.Length  / 2).ToArray();

            //Console.WriteLine(String.Join(", ", firstArray));
            //Console.WriteLine(String.Join(", ", secondArray));

            /*Array.Sort(firstArray);
            Array.Sort(secondArray);
            Array.Reverse(secondArray);

            int[] result1 = firstArray.Concat(secondArray).ToArray();*/

            /*foreach (var item in result1)
			{
				//Console.WriteLine(item);
			}*/
        }
    }
}