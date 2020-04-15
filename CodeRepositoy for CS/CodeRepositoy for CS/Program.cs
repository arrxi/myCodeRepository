using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeRepositoy_for_CS
{

    public class Program {

        public static void Main(String[] args)
        {
            //SortTest();
            Console.WriteLine("hle".Mul(4));
            Console.ReadLine();



        }
        public static void SortTest()
        {
            Random rd = new Random();
            List<int> list = new List<int>();
            for (int i = 0; i < 50; i++)
            {
                list.Add(rd.Next(100));
                Console.Write(list[i]+"  ");
            }
            Console.WriteLine();
            //SortHelper.InsertSort(list, 0, list.Count - 1, (a, b) => { return a - b; });
            //SortHelper.InsertSort(list,0,list.Count-1,(a, b) => { return a - b; });
            SortHelper.ShellSort(list, (a, b) => { return a - b; });
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i]+"  ");
            }

        }
    }
}
