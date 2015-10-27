using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedLists
{
    public class MyStack<T>
    {
        private Node<T> head;
        private int count;
        public MyStack()
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
            tmpNode.Next = head;
            head = tmpNode;
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
