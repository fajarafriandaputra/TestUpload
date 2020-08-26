using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //emp obj = new emp();
            //obj.name = "Aksay";
            //obj.adress = "new delhi";
            //obj.display();

            //sample obj = new sample();
            //sample.first();
            //obj.second(10);

            //int num = 2;
            //fun1(ref num);
            //Console.WriteLine(num);

            //int[] arr = new int[] { 1, 2, 3, 4, 5 };
            //fun1(ref arr);

            //int x = 4, b = 2;
            //x -= b /= x * b;
            //Console.WriteLine(x + " " + b);


            //int x = 8;
            //int b = 16;
            //int c = 64;
            //x /= c /= b;
            //Console.WriteLine(x + " " + b + " " + c);

            //sample2 s = new sample2(9, 2.5);
            //sum s = new sum(4, 5, 9);

            int num = 5;
            int square = 0, cube = 0;
            Mul(num, ref square, ref cube);
            Console.WriteLine(square + "&" + cube);

            Console.ReadLine();

        }

        static void Mul (int num, ref int square,ref int cube)
        {
            square = num * num;
            cube = num * num * num;
        }

        static void fun1(ref int num)
        {
            num = num * num * num;
        }
        static void fun1(ref int[] array)
        {
            for (int i = 0; i < array.Length; i = i + 2)
            {
                array[i] = array[i] + 10;
            }

            Console.WriteLine(string.Join(",", array));
        }
    }

    class emp
    {
        public string name;
        public string adress;
        public void display()
        {
            Console.WriteLine("{0} is the city {1}", name, adress);
        }


    }

    class sample
    {
        public static void first()
        {
            Console.WriteLine("first method");
        }
        public static void second()
        {
            Console.WriteLine("second method");
        }

        public void second(int i)
        {
            Console.WriteLine(i);
            second();
        }

    }

    class sample2
    {
        int i;
        double k;
        public sample2(int ii, double kk)
        {
            i = ii;
            k = kk;
            double j = (i) + (k);
            Console.WriteLine(j);
        }
        ~sample2()
        {
            double j = i - k;
            Console.WriteLine(j);
        }
    }

    class sum
    {
        public int value;
        int num1;
        int num2;
        int num3;

        public sum(int a, int b, int c)
        {
            this.num1 = a;
            this.num2 = b;
            this.num3 = c;
        }
        ~sum()
        {
            value = this.num1 * this.num2 * this.num3;
            Console.WriteLine(value);
        }
    }

}
