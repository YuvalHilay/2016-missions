using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraymission4
{
    class Program
    {
        static void Main(string[] args)
        {
            Array a = new Array(10, 20);
            Array b = new Array(10, 20);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine("The sum of array A is: {0}", a.SumArray());
            Console.WriteLine("The sum of array B is: {0}", b.SumArray());
            Console.WriteLine("The avarege ammount in the A array is : {0}", a.Average());
            Console.WriteLine("The avarege amount in the B array is: {0}", b.Average());
            Console.WriteLine("There are {0} numbers in the A array bigger than 13", a.countAbove(13));
            Console.WriteLine("There are {0} numbers in the B array bigger than 13", b.countAbove(13));
            Console.WriteLine("The number 9 {0} in the A array", a.contains(9));
            Console.WriteLine("The number 9 {0} in the B array", b.contains(9));
            Console.WriteLine("The arrays are {0} in comparison", a.arrayIsEqual(b));
            a.sort('+');
            b.sort('-');
            Console.WriteLine(a);
            Console.WriteLine(b);


        }
        class Array
        {
            private int[] arr;
            private int size;
          static Random num = new Random();
            public Array(int size, int n)
            {
                this.size = size;
                this.arr = new int[size];
                
                for (int i = 0; i < size; i++)
                {
                    arr[i] = num.Next(1, n);
                }
            }
            public void SetElement(int index, int value)
            {
                this.arr[index] = value;
            }
            public int SumArray()
            {
                int sum = 0;
                for (int i = 0; i < this.size; i++)
                    sum += this.arr[i];
                return sum;
            }
            public double Average()
            {
                int sum = SumArray();
                double avg = 0;
                avg = (double)(sum) / this.size;
                return avg;
            }
            public int countAbove(int x)
            {
                int count = 0;
                for (int i = 0; i < this.size; i++)
                    if (this.arr[i] > x)
                        count++;
                return count;
            }
            public bool contains(int x)
            {
                for (int i = 0; i < this.size; i++)
                    if (this.arr[i] == x)
                        return true;
                return false;
            }
            public void sort(char sign)
            {
                int temp;
                if (sign == '+')
                {
                    for (int i = 0; i < this.size - 1; i++)
                    {
                        for (int j = 0; j < this.size - 1; j++)
                            if (this.arr[j] > this.arr[j + 1])
                            {
                                temp = this.arr[j];
                                this.arr[j] = this.arr[j + 1];
                                this.arr[j + 1] = temp;
                            }
                    }
                }
                if (sign == '-')
                {
                    for (int i = 0; i < this.size - 1; i++)
                    {
                        for (int j = 0; j < this.size - 1; j++)
                            if (this.arr[j] < this.arr[j + 1])
                            {
                                temp = this.arr[j];
                                this.arr[j] = this.arr[j + 1];
                                this.arr[j + 1] = temp;
                            }
                    }
                }
            }
            public bool arrayIsEqual(Array a1)
            {
                for (int i = 0; i < this.size; i++)
                    if (this.arr[i] != a1.arr[i])
                        return false;
                return true;
            }
            public override string ToString()
            {
                string st = "";
                for (int i = 0; i < this.size; i++)
                    st += this.arr[i] + ",";
                return st;
            }

        }
    }
}