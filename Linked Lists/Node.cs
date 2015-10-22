using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedLists
{
    class Node<T>
    {
        private T data;
        public Node(T setData)
        {
            data = setData;
        }
        public Node<T> Next
        {
            get;
            set;
        }
        public T Data
        {
            get{return data;}
        }
    }
}
