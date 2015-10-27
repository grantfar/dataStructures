using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedLists
{
    public class MyQueue<T>
    {
        private Node<T> head,end;
        private int count;
        public MyQueue()
        {
            count = 0;
        }
        public int Count
        {
            get { return count; }
        }

        public void Add(T toAdd)
        {
            Node<T> tmpNode = new Node<T>(toAdd);
            if (head == null)
                head = tmpNode;
            else
                end.Next = tmpNode;
            end = tmpNode;
            count++;
        }

        public T get()
        {
            T returnT = head.Data;
            head = head.Next;
            count--;
            return returnT;
        }
    }
}
