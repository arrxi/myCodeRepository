using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeRepositoy_for_CS {

    public class Program {

        public static void Main(String[] args)
        {
            //SortTest();
            //Console.WriteLine("hle".Mul(4));
            TestLinkedListD();
            Console.ReadLine();
        }

        public static void TestLinkedListD()
        {
            DoublyLinkedList<Ixl> linklist = new DoublyLinkedList<Ixl>();
            for (int i = 0; i < 10; i++)
            {
                linklist.Add(new Ixl());
            }
            Console.WriteLine(linklist.count);
        }

        public static void SortTest()
        {
            Random rd = new Random();
            List<int> list = new List<int>();
            for (int i = 0; i < 50; i++)
            {
                list.Add(rd.Next(100));
                Console.Write(list[i] + "  ");
            }
            Console.WriteLine();
            //SortHelper.InsertSort(list, 0, list.Count - 1, (a, b) => { return a - b; });
            //SortHelper.InsertSort(list,0,list.Count-1,(a, b) => { return a - b; });
            SortHelper.ShellSort(list, (a, b) => { return a - b; });
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + "  ");
            }
        }
    }

    internal class Ixl {
        private static Random rd = new Random();
        public int t;

        public Ixl()
        {
            t = rd.Next(100);
        }
    }
}