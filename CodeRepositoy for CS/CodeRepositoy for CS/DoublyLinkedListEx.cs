using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Collections.Generic {

    public partial class DoublyLinkedList<T> : IEnumerable<T> {
        private ForeachEnum1 foreache;

        public T this[int index]
        {
            get
            {
                return GetAt(index).data;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            if (foreache == null)
            {
                foreache = new ForeachEnum1(this);
            }
            return foreache;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            if (foreache == null)
            {
                foreache = new ForeachEnum1(this);
            }
            return foreache;
        }

        public class ForeachEnum1 : IEnumerator<T> {
            public T Current { get => currentNode == null ? default(T) : currentNode.data; }

            object IEnumerator.Current { get; }
            private Node<T> currentNode { get; set; }
            private DoublyLinkedList<T> list;

            public ForeachEnum1(DoublyLinkedList<T> list)
            {
                this.list = list;
            }

            public void Dispose()
            {
                Console.WriteLine("dispose");
                currentNode = null;
            }

            public bool MoveNext()
            {
                if (currentNode == null)
                {
                    currentNode = list.head;
                    return true;
                }
                else
                {
                    if (currentNode.IsEnd)
                    {
                        return false;
                    }
                    else
                    {
                        currentNode = currentNode.Next();
                        return true;
                    }
                }
            }

            /// <summary>
            /// TODO
            /// </summary>
            public void Reset()
            {
                Console.WriteLine("reset");
                currentNode = null;
            }
        }
    }
}