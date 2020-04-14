using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeRepositoy_for_CS {
    public class SortHelper {
        /// <summary>
        /// 快排
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="startindex"></param>
        /// <param name="endindex"></param>
        /// <param name="comparison"></param>
        public static void QuickSort<T>(IList<T> list, int startindex, int endindex, Comparison<T> comparison)
        {
            if (endindex - startindex <= 1)
            {
                return;
            }
            T tmp = default(T);
            int index = startindex;
            for (int i = index + 1; i <= endindex; i++)
            {
                if (comparison.Invoke(list[i], list[index]) < 0)
                {
                    tmp = list[i];
                    for (int j = i - 1; j >= index; j--)
                    {
                        list[j + 1] = list[j];
                    }
                    list[index] = tmp;
                    index++;
                }
            }
            QuickSort(list, startindex, index - 1, comparison);
            QuickSort(list, index + 1, endindex, comparison);
        }
        /// <summary>
        /// 插入排序
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="startindex"></param>
        /// <param name="endindex"></param>
        /// <param name="comparison"></param>
        public static void InsertSort<T>(List<T> arr, int startIndex, int endIndex, Comparison<T> comparison)
        {
            T tmp = default(T);
            int i, j;
            for (i = startIndex; i <= endIndex; i++)
            {
                tmp = arr[i];// 相当于[当前牌],这里赋给tmp起临时保存的作用
                j = i - 1;// 将当前牌与手中的牌依次比较
                while (j >= 0 && comparison.Invoke(tmp, arr[j]) < 0)//改变判断条件,实现从小到大地排列
                {
                    arr[j + 1] = arr[j];// 将元素后移
                    j--;
                }
                // j+1(因为上边的while循环多做了一次判断)即为当前牌插入的位置
                arr[j + 1] = tmp;
            }
        }
        /// <summary>
        /// 希尔排序
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="comparison"></param>
        public static void ShellSort<T>(IList<T> list,Comparison<T> comparison)
        {
            int inc;
            for (inc = 1; inc <= list.Count / 9; inc = 3 * inc + 1) ;
            for (; inc > 0; inc /= 3)
            {
                for (int i = inc + 1; i <= list.Count; i += inc)
                {
                    T t = list[i - 1];
                    int j = i;
                    while ((j > inc) && comparison.Invoke(list[j - inc - 1] , t)>0)
                    {
                        list[j - 1] = list[j - inc - 1];
                        j -= inc;
                    }
                    list[j - 1] = t;
                }
            }
        }
    }
    public class ShellSorter {
        public void Sort(List<int> list)
        {
            int inc;
            for (inc = 1; inc <= list.Count / 9; inc = 3 * inc + 1) ;
            for (; inc > 0; inc /= 3)
            {
                for (int i = inc + 1; i <= list.Count; i += inc)
                {
                    int t = list[i - 1];
                    int j = i;
                    while ((j > inc) && (list[j - inc - 1] > t))
                    {
                        list[j - 1] = list[j - inc - 1];
                        j -= inc;
                    }
                    list[j - 1] = t;
                }
            }
        }
    }
}
