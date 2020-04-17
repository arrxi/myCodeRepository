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

        /// <summary>
        /// 双向链表测试函数
        /// </summary>
        public static void TestLinkedListD()
        {
            DoublyLinkedList<TestClass> linklist = new DoublyLinkedList<TestClass>();
            for (int i = 0; i < 10; i++)
            {
                linklist.Add(new TestClass());
            }
            Console.WriteLine(linklist.count);
            Console.WriteLine();
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(linklist.GetAt(i).data.t);
            //}

            foreach (TestClass ixl in linklist)
            {
                Console.WriteLine(ixl.t);
            }
            Console.WriteLine();

            foreach (TestClass ixl in linklist)
            {
                Console.WriteLine(ixl.t);
            }
            Console.WriteLine("----------------");
            Console.WriteLine("第{0}个元素：{1}", 4, linklist[12]);
        }

        /// <summary>
        /// 排序测试函数
        /// </summary>
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

    /// <summary>
    ///测试类
    /// </summary>
    internal class TestClass {
        private static Random rd = new Random();
        public int t;

        public TestClass()
        {
            t = rd.Next(100);
        }
    }
}