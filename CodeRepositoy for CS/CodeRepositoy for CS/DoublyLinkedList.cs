namespace System.Collections.Generic {

    public partial class DoublyLinkedList<T> {
        public Node<T> head;
        public Node<T> tail;
        public int count = 0;

        public void Insert(T t, int index)
        {
            if (count > index)
            {
                Node<T> tmp = head; int i = 0;
                while (true)
                {
                    tmp = tmp.child;
                    if (i == index)
                    {
                        Node<T> newNode = new Node<T>() { data = t };

                        newNode.parent = tmp.parent;
                        newNode.child = tmp.child;

                        newNode.parent.child = newNode;
                        newNode.child.parent = newNode;
                        break;
                    }
                    i++;
                }
                count++;
            }
            else
            {
                throw new IndexOutOfRangeException();
                //Add(t);
            }
        }

        public void InsertAfterNode(Node<T> node, T t)
        {
            Node<T> inser = new Node<T>() { data = t };
            bool isend = node.IsEnd;
            node.child = inser;
            inser.parent = node;
            if (!isend)
            {
                node.child.parent = inser;
                inser.child = node.child;
            }
            else
            {
                tail = inser;
            }

            count++;
        }

        public void InsertBeforeNode(Node<T> node, T t)
        {
            Node<T> inser = new Node<T>() { data = t };
            bool isstart = node.IsStart;
            inser.child = node.child;
            node.child.parent = inser;
            if (!isstart)
            {
                node.parent.child = inser;
                inser.parent = node;
            }
            else
            {
                head = inser;
            }

            count++;
        }

        /// <summary>
        /// 在链表尾端添加元素
        /// </summary>
        /// <param name="t"></param>
        public void Add(T t)
        {
            if (head == null)
            {
                head = new Node<T>() { data = t };
                tail = head;
            }
            else
            {
                var tmp = new Node<T>() { data = t };
                tmp.parent = tail;
                tmp.parent.child = tmp;
                tail = tmp;
            }
            count++;
        }

        /// <summary>
        /// 删除尾节点
        /// </summary>
        public void Remove()
        {
            if (count >= 1)
            {
                tail = tail.parent;
                tail.child = null;
                count--;
            }
            else
            {
                Console.WriteLine("列表数据为空");
            }
        }

        public void Remove(Node<T> node)
        {
            if (node.IsStart)
            {
                node.child.parent = null;
                head = node.child;
            }
            else if (node.IsEnd)
            {
                node.parent.child = null;
                tail = node.parent;
            }
            else
            {
                node.parent.child = node.child;
                node.child.parent = node.parent;
            }
            count--;
        }

        /// <summary>
        /// 返回并删除尾节点 ，为空时候返回空
        /// </summary>
        /// <returns></returns>
        public T Pop()
        {
            if (count >= 1)
            {
                var tmp = tail.data;
                tail = tail.parent;
                tail.child = null;
                count--;
                return tmp;
            }
            else
            {
                return default(T);
            }
        }

        /// <summary>
        /// 返回并删除头节点
        /// </summary>
        /// <returns></returns>
        public T PopOnHead()
        {
            if (count <= 0)
            {
                return default(T);
            }
            else
            {
                var tmp = head;
                head = tail;
                if (head != null)
                {
                    head.parent = null;
                }
                count--;
                return tmp.data;
            }
        }

        private Node<T> SelectAt(int index)
        {
            if (count > index)
            {
                Node<T> tmp = head;
                for (int i = 0; i < count; i++)
                {
                    if (i == index)
                    {
                        return tmp;
                    }
                    else
                    {
                        tmp = tmp.child;
                    }
                }
                return tmp;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        /// <summary>
        ///删除固定索引的元素
        /// </summary>
        /// <param name="index"></param>
        public void RemoveAt(int index)
        {
            if (count > index)
            {
                Node<T> tmp = head; int i = 0;
                while (true)
                {
                    tmp = tmp.child;
                    if (i == index)
                    {
                        tmp.parent.child = tmp.child;
                        tmp.child.parent = tmp.parent;
                        tmp.child = null;
                        tmp.parent = null;
                        count--;
                        break;
                    }
                }
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
    }

    public class Node<T> {
        public bool IsStart { get => parent == null ? true : false; }

        public bool IsEnd { get => child == null ? true : false; }
        public Node<T> parent;
        public Node<T> child;
        public T data;

        public Node<T> Next()
        {
            return child;
        }

        public Node<T> Last()
        {
            return parent;
        }
    }
}