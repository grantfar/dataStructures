using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedLists
{
    public class LinkedListOV<T>
    {
        private Node<T> head;
        private int count;
        public LinkedListOV()
        {
            count = 0;
        }
        public int Count
        {
            get { return count; }
        }
        public void Add(T toAdd)
        {
            Node<T> tmpNode = head;
            Node<T> addedNode = new Node<T>(toAdd);
            head = addedNode;
            head.Next = tmpNode;
            count++;
        }
        
        public void RemoveAt(int index)
        {
            if (index > count || index < 0)
                throw new IndexOutOfRangeException();
            if(index == 0)
            {
                head = head.Next;
            }
            Node<T> prevNode = head;
            Node<T> tmpNode = head;
            for (int i = 0; i < index; i++)
            {
                prevNode = tmpNode;
                tmpNode = tmpNode.Next;
            }
            prevNode.Next = tmpNode.Next;
            count--;
        }

        public bool Remove(T toRemove)
        {
            if (toRemove.Equals(head.Data))
            {
                head = head.Next;
                count--;
                return true;
            }
            Node<T> prevNode = head;
            Node<T> tmpNode = head;
            while(tmpNode != null)
            {
                if(tmpNode.Data.Equals(toRemove))
                {
                    prevNode.Next = tmpNode.Next;
                    count--;
                    return true;
                }
                prevNode = tmpNode;
                tmpNode = tmpNode.Next;
            }
            return false;
        }

        public T ReturnAt(int index)
        {
            if (index > count || index < 0)
                throw new IndexOutOfRangeException();
            Node<T> tmpNode = head;
            for (int i = 0; i < index; i++)
            {
                tmpNode = tmpNode.Next;
            }
            return tmpNode.Data;
        }

        public bool Contains(T isIn)
        {
            Node<T> tmpNode = head;
            while(tmpNode != null)
            {
                if (tmpNode.Data.Equals(isIn))
                    return true;
                tmpNode = tmpNode.Next;
            }
            return false;
        }


    }
}
