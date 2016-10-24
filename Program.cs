using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        
        public void swap(int a, int b) {
            int c = a;
            a=b;
            b =c;
            //Console.WriteLine(a+" "+b);
        }
       public int partitionFiunction(int[] array,int  lower, int upper) {
            int pivort = array[lower];
            int p = lower;
            int q=upper;
            while (q >= p) {

                while (array[p] < pivort) {
                    if (p < upper)
                        ++p;
                } ;
                while (array[--q] > pivort) ;
                
                if (p < q) {
                    swap(array[p], array[q]);
                }
            }
            swap(array[lower], array[q]);

            return q;

        }

        void quickSort(int[] array, int lower, int upper) {
            int z = 0;
            if (lower < upper) {
                z = partitionFiunction(array, lower, upper);
                quickSort(array, lower, z - 1);
                quickSort(array, z + 1, upper);
            }
            

        }
        void print(int[] array) {

            for (int i = 0; i < array.Length; i++) {
                Console.Write(array[i] + " ");
            }
        }

        static void Main(string[] args)
        {
           int [] array = { 11, 2, 13, 44, 16,7 };
            Program p = new Program();
            p.quickSort(array, 0, array.Length-1);
            p.print(array);

        }
    }
}
